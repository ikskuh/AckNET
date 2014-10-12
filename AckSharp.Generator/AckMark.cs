using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AckSharp.Generator
{
	public sealed class AckMark : IDisposable
	{
		private readonly StreamReader reader;
		private readonly TextWriter writer;
		private bool stopped = false;
		private int byteOffset = 0;
		private string currentClass = null;

		Regex cleanup = new Regex(@"\s+", RegexOptions.Compiled);

		Regex matchInstruction = new Regex(@"^#(\w+)(?: (\w+))*", RegexOptions.Compiled);
		Regex matchSkip = new Regex(@"^skip (\d+)", RegexOptions.Compiled);
		Regex matchEvent = new Regex(@"^event (ro|rw) (\w+)(?: (\w+))?", RegexOptions.Compiled);
		Regex matchVector = new Regex(@"^(vector|angle|color) (ro|rw) (\w+)(?: (\w+))?", RegexOptions.Compiled);
		Regex matchFlags = new Regex(@"^(?:flags|enum) (ro|rw) (\w+) (\w+)", RegexOptions.Compiled);
		Regex matchVariable = new Regex(@"^(var|int|float|ptr) (ro|rw) (\w+)", RegexOptions.Compiled);
		Regex matchString = new Regex(@"^string (ro|rw) (\w+)", RegexOptions.Compiled);
		Regex matchObject = new Regex(@"^(ackstring|bmap|entity|material|panel|text|sound|font|view) (ro|rw) (\w+)", RegexOptions.Compiled);
		Regex matchIndexer = new Regex(@"^index (int|var|float) (ro|rw) (\d+)", RegexOptions.Compiled);

		Dictionary<Regex, MatchEvaluator> processors;

		Dictionary<string, string[]> typeMap = new Dictionary<string, string[]>()
			{
				{"int", new [] { "int" ,"GetInt", "SetInt"} },
				{"var", new [] {"ackvar", "GetVar", "SetVar" } },
				{"float", new [] {"float", "GetFloat", "SetFloat" } },
				{"ptr", new [] {"IntPtr", "GetPtr", "SetPtr" } },
				{"ackstring", new [] { "AckString", "Get<AckString>", "Set" } },
				{"bmap", new [] { "Bitmap", "Get<Bitmap>", "Set" } },
				{"entity", new [] {"Entity", "Get<Entity>", "Set" } },
				{"material", new [] {"Material", "Get<Material>", "Set" } },
				{"panel", new [] {"Panel", "Get<Panel>", "Set" } },
				{"text", new [] {"Text", "Get<Text>", "Set" } },
				{"sound", new [] {"Sound", "Get<Sound>", "Set" } },
				{"font", new [] {"Font", "Get<Font>", "Set" } },
				{"view", new [] {"View", "Get<View>", "Set" } },
			};

		private AckMark(string source, string target)
		{
			this.reader = new StreamReader(source);
			this.writer = new StreamWriter(target, false, Encoding.UTF8);

			this.processors = new Dictionary<Regex, MatchEvaluator>()
			{
				{ matchInstruction, this.ProcessInstruction },
				{ matchSkip, this.ProcessSkip },
				{ matchEvent, this.ProcessEvent },
				{ matchVector, this.ProcessVector },
				{ matchFlags, this.ProcessFlags },
				{ matchVariable, this.ProcessVariable },
				{ matchString, this.ProcessString },
				{ matchObject, this.ProcessVariable },
				{ matchIndexer, this.ProcessIndexer },
			};
		}

		private string ProcessInstruction(Match match)
		{
			string result;
			switch (match.Groups[1].Value)
			{
				case "class":
					result = "";
					if (currentClass != null)
						result += "}\n";
					this.currentClass = match.Groups[2].Value;
					this.byteOffset = 0;
					result += "partial class " + this.currentClass + "\n";
					result += "{\n";
					return result;
				case "end":
					this.stopped = true;
					break;
			}
			return "";
		}

		private string ProcessSkip(Match match)
		{
			byteOffset += int.Parse(match.Groups[1].Value);
			return "";
		}

		private string ProcessVariable(Match match)
		{
			var type = typeMap[match.Groups[1].Value];
			var mod = match.Groups[2].Value;
			var name = match.Groups[3].Value;

			string text = string.Format(
				mod == "rw" ?
					"public {0} {4} {{ get {{ return {2}({1}); }} set {{ {3}({1}, value); }} }}" :
					"public {0} {4} {{ get {{ return {2}({1}); }} }}",
				type[0],
				byteOffset,
				type[1],
				type[2],
				name);
			byteOffset += 4;
			return text;
		}


		private string ProcessString(Match match)
		{
			var mod = match.Groups[1].Value;
			var name = match.Groups[2].Value;

			string text = string.Format(
				mod == "rw" ?
					"NativeString ns{1} = new NativeString();\npublic string {1} {{ get {{ return GetString({0}); }} set {{ SetString({0}, ns{1}, value); }} }}" :
					"public string {1} {{ get {{ return GetString({0}); }} }}",
				byteOffset,
				name);
			byteOffset += 4;
			return text;
		}

		private string ProcessIndexer(Match match)
		{
			var type = typeMap[match.Groups[1].Value];
			var mod = match.Groups[2].Value;
			var count = int.Parse(match.Groups[3].Value);

			string text = string.Format(
				mod == "rw" ?
					"public {0} this[int idx] {{\n" +
					"get {{\n" +
					"if(idx < 0 || idx >= {4}) throw new IndexOutOfRangeException();\n" +
					"return {2}({1} + 4 * idx);\n" +
					"}}\n" +
					"set {{\n" +
					"if(idx < 0 || idx >= {4}) throw new IndexOutOfRangeException();\n" +
					"{3}({1} + 4 * idx, value);\n" +
					"}}\n}}" :
					"public {0} this[int idx] {{\n" +
					"get {{\n" +
					"if(idx < 0 || idx >= {4}) throw new IndexOutOfRangeException();\n" +
					"return {2}({1} + 4 * idx);\n" +
					"}}\n}}",
				type[0],
				byteOffset,
				type[1],
				type[2],
				count);
			byteOffset += 4 * count;
			return text;
		}


		private string ProcessEvent(Match match)
		{
			var mod = match.Groups[1].Value;
			var name = match.Groups[2].Value;
			var type = match.Groups[3].Value;
			if (string.IsNullOrWhiteSpace(type)) type = "EngineEventDelegate";

			string text = string.Format(
				"NativeEvent ne{2};" + "\n" +
				"public {0} {2}" + "\n" +
				"{{" + "\n" +
					"get {{ return ({0})GetEvent({1}, ref ne{2}, typeof({0})); }}" + "\n" +
					(mod == "rw" ? "set {{ SetEvent({1}, ref ne{2}, value); }}" + "\n" : "") +
				"}}",
				type,
				byteOffset,
				name);
			byteOffset += 4;
			return text;
		}

		private string ProcessFlags(Match match)
		{
			var mod = match.Groups[1].Value;
			var name = match.Groups[2].Value;
			var type = match.Groups[3].Value;

			string text = string.Format(
				mod == "rw" ?
					"public {0} {2} {{ get {{ return ({0})GetInt({1}); }} set {{ SetInt({1}, (int)value); }} }}" :
					"public {0} {2} {{ get {{ return ({0})GetInt({1}); }} }}",
				type,
				byteOffset,
				name);
			byteOffset += 4;
			return text;
		}


		private string ProcessVector(Match match)
		{
			Dictionary<string, string[]> typeMap = new Dictionary<string, string[]>()
			{
				{"vector", new [] { "Vector", "X", "Y", "Z"} },
				{"angle", new [] {"Angle", "Pan", "Tilt", "Roll" } },
				{"color", new [] {"Color","Red", "Green", "Blue" } },
			};

			var type = typeMap[match.Groups[1].Value];
			var mod = match.Groups[2].Value;
			var name = match.Groups[3].Value;
			var prefix = match.Groups[4].Value ?? "";

			string text = string.Format(
				mod == "rw" ?
					"public {0} {1} {{ get {{ return Get{0}({5}); }} set {{ Set{0}({5}, value); }} }}\n" +
					"public ackvar {2} {{ get {{ return GetVar({5}); }} set {{ SetVar({5}, value); }} }}\n" +
					"public ackvar {3} {{ get {{ return GetVar({6}); }} set {{ SetVar({6}, value); }} }}\n" +
					"public ackvar {4} {{ get {{ return GetVar({7}); }} set {{ SetVar({7}, value); }} }}" :
					"public {0} {1} {{ get {{ return Get{0}({5}); }} }}\n" +
					"public ackvar {2} {{ get {{ return GetVar({5}); }} }}\n" +
					"public ackvar {3} {{ get {{ return GetVar({6}); }} }}\n" +
					"public ackvar {4} {{ get {{ return GetVar({7}); }} }}",
				type[0],
				name,
				prefix + type[1],
				prefix + type[2],
				prefix + type[3],
				byteOffset + 0,
				byteOffset + 4,
				byteOffset + 8);

			byteOffset += 12;
			return text;
		}

		private string ProcessNotImplemented(Match match)
		{
			return "// Not implemented: " + match.Value;
		}

		public static void Generate(string source, string target)
		{
			using (AckMark mark = new AckMark(source, target))
			{
				mark.Process();
			}
		}

		private void Process()
		{
			this.writer.WriteLine("namespace AckSharp");
			this.writer.WriteLine("{");
			this.writer.WriteLine("using System;");
			while (!this.reader.EndOfStream && this.stopped == false)
			{
				var line = cleanup.Replace(this.reader.ReadLine(), " ").Trim();
				if (line.Length == 0)
					continue;

				string result = null;
				foreach (var kv in this.processors)
				{
					var match = kv.Key.Match(line);
					if (match.Success)
					{
						result = kv.Value(match);
					}
					if (result != null)
						break;
				}
				if (result != null)
				{
					if (result.Length > 0)
					{
						this.writer.WriteLine();
						this.writer.WriteLine(result);
					}
				}
				else
				{
					this.writer.WriteLine("// Failed to process {0}", line);
				}
			}
			if (this.currentClass != null)
				this.writer.WriteLine("}");
			this.writer.WriteLine("}");
		}

		public void Dispose()
		{
			this.reader.Close();
			this.writer.Close();
			this.reader.Dispose();
			this.writer.Dispose();
		}
	}
}
