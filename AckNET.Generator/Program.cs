using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AckNET.Generator
{
	class Program
	{
		static void Main(string[] args)
		{
			GenerateEngineVars();
        }

		static void GenerateEngineVars()
		{
			Regex arrayCheck = new Regex(@"\[\d+\]", RegexOptions.Compiled);
			Regex stringFix = new Regex(@"\s+", RegexOptions.Compiled);

			var lines = File.ReadAllLines(@"C:\Program Files (x86)\GStudio8\sdk_engine\avars2.h");
			using (var writer = new StreamWriter(@"D:\AckNET\AckNET\EngineVars.Generated.cs"))
			{
				writer.WriteLine("namespace AckNET\n{\n\tusing System;\n\tpartial class EngineVars\n\t{\n");
				int ptrOffset = 0;
				foreach (var line in lines)
				{
					if (line.Trim().Length == 0)
						continue;

					string @fixed = stringFix.Replace(line, " ");
					string[] parts = @fixed.Split(' ');

					var match = arrayCheck.Match(line);
					if (match.Success)
					{
						var group = match.Groups[0];

						var lenString = group.Value.Substring(1, group.Value.Length - 2);

						ptrOffset += int.Parse(lenString) * 4;

						continue;
					}
					writer.WriteLine();
					writer.WriteLine("\t\t// {0}", line);
					switch (parts[0])
					{
						case "ENGINE_VAR":
							writer.WriteLine(
								"\t\tpublic static ackvar {0} {{ get {{ return GetVar({1}); }} set {{ SetVar({1}, value); }} }}",
								 FixName(parts[1]),
								 ptrOffset);
							break;
						case "ENGINE_VECTOR":

							break;
						case "ENGINE_ANGLE":

							break;
						case "ENGINE_COLOR":

							break;
						case "ENGINE_EVENT":
							writer.WriteLine("\t\tprivate static EngineEventDelegate {0};", FixName(parts[1], true));
							writer.WriteLine(
								"\t\tpublic static EngineEventDelegate {0} {{ get {{ return {1}; }} set {{ {1} = value; SetEvent({2}, {1}); }} }}",
								FixName(parts[1], false),
								FixName(parts[1], true),
								ptrOffset);
							break;
						case "ENGINE_ENTITY":
							writer.WriteLine(
								"\t\tpublic static Entity {0} {{ get {{ return GetEntity({1}); }} set {{ SetEntity({1}, value); }} }}",
								 FixName(parts[1]),
								 ptrOffset);
							break;
						case "ENGINE_VIEW":

							break;
						case "ENGINE_BMAP":

							break;
						case "ENGINE_MATERIAL":

							break;
						case "ENGINE_STRING":

							break;
						case "ENGINE_PANEL":

							break;
						case "ENGINE_CONTACT":

							break;
						case "void*":
							writer.WriteLine(
								"\t\tpublic static IntPtr {0} {{ get {{ return GetPtr({1}); }} set {{ SetPtr({1}, value); }} }}",
								FixName(parts[1]),
								ptrOffset);
							break;
						case "ENGINE_":
							switch (parts[1])
							{
								case "void*":
									writer.WriteLine(
										"\t\tpublic static IntPtr {0} {{ get {{ return GetPtr({1}); }} set {{ SetPtr({1}, value); }} }}",
										FixName(parts[2]),
										ptrOffset);
									break;
								default:
									writer.WriteLine("// {0}", line);
									Console.WriteLine("Unknown line: {0}", line);
									break;
							}
							break;
						default:
							writer.WriteLine("// {0}", line);
							Console.WriteLine("Unknown line: {0}", line);
							continue;
					}
					ptrOffset += 4;
				}

				writer.WriteLine("\t}\n}");
			}
		}
		static string FixName(string name, bool firstLowerCase = false)
		{
			if (name.EndsWith(";"))
				name = name.Substring(0, name.Length - 1);

			StringBuilder builder = new StringBuilder();

			for (int i = 0; i < name.Length; i++)
			{
				if (i == 0 && !firstLowerCase)
				{
					builder.Append(name[i].ToString().ToUpper());
				}
				else if (name[i] == '_')
				{
					builder.Append(name[++i].ToString().ToUpper());
				}
				else
				{
					builder.Append(name[i]);
				}
			}

			return builder.ToString();
		}
	}
}
