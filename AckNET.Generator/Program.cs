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
			//GenerateFunctions();
			GenerateEngineVars();
		}

		static void GenerateFunctions()
		{
			var lines = File.ReadAllText(@"C:\Program Files (x86)\GStudio8\sdk_engine\afuncs2.h").Split(';');
			for (int i = 0; i < lines.Length; i++)
			{
				lines[i] = Regex.Replace(lines[i].Trim(), @"\s+", " ");
            }

			using (var writer = new StreamWriter(@"D:\AckNET\AckNET\Native\NativeMethods.cs"))
			{
				writer.WriteLine("using System;");
				writer.WriteLine("using System.Runtime.InteropServices;");
				writer.WriteLine("namespace AckNET.Native");
				writer.WriteLine("{");
				writer.WriteLine("\tpublic static class NativeMethods");
				writer.WriteLine("\t{");

				foreach(var line in lines)
				{
					var parts = line.Split(new[] { ' ',',', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
					if (parts.Length < 2) continue;

					writer.WriteLine("\t\t"+ @"[DllImport(""acknex.dll"", EntryPoint=""{0}"", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]", parts[1]);

					bool isPointered;
					string returnType = MapResultType(parts[0], out isPointered);
					if(isPointered)
					{
						writer.Write("\t\t");
						writer.WriteLine("[return : MarshalAs(UnmanagedType.LPStruct)]");
					}

					writer.Write("\t\t");
					writer.Write("public static extern {0} {1}(",
						returnType,
						FixName(parts[1]));

					for (int i = 2; i < parts.Length; i++)
					{
						if (parts[i] == "void")
							continue;
						writer.Write(MapParamType(parts[i]));
						writer.Write(" ");
                        writer.Write("param{0}", i - 2);

						if (i < parts.Length - 1)
							writer.Write(", ");
					}

					writer.WriteLine(");");
					writer.WriteLine();
				}


				writer.WriteLine("\t}");
				writer.WriteLine("}");

			}
		}

		static string MapResultType(string input, out bool isPointered)
		{
			isPointered = false;
			switch(input)
			{
				case "var": return "ackvar";
				case "VECTOR*":
					isPointered = true;
					return "Vector";
				case "ANGLE*":
					isPointered = true;
					return "Angle";
				case "COLOR*":
					isPointered = true;
					return "Color";
				case "VIEW*":
				case "BMAP*":
				case "ENTITY*":
				case "SOUND*":
				case "MATERIAL*":
				case "PARTICLE*":
				case "CONTACT*":
				case "STRING*":
				case "FONT*":
				case "PANEL*":
				case "TEXT*":
				case "ENGINE_VARS*":
                case "void*":
				case "void**":
				case "void***":
					return "IntPtr";
				case "char*": return "string";
				default:
					return input;
			}
		}
		static string MapParamType(string input)
		{
			switch (input)
			{
				case "var": return "ackvar";
				case "VECTOR*":
					return "ref Vector";
				case "ANGLE*":
					return "ref Angle";
				case "COLOR*":
					return "ref Color";
				case "VIEW*":
				case "BMAP*":
				case "ENTITY*":
				case "SOUND*":
				case "FONT*":
				case "CONTACT*":
				case "PANEL*":
				case "MATERIAL*":
				case "TEXT*":
				case "STRING*":
				case "void*":
				case "void**":
				case "void***":
					return "IntPtr";
				case "ENTITY**":
					return "ref IntPtr";
				case "DWORD":
					return "int";
                case "long*":
					return "ref int";
				case "EVENT":
					return "IntPtr";
				case "var*":
					return "ref ackvar";
				case "char*":return "string";
				case "char**": return "IntPtr";
				default:
					return input;
			}
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
								"\t\tpublic static Entity {0} {{ get {{ return GetEntity({1}); }} set {{ SetObject({1}, value); }} }}",
								 FixName(parts[1]),
								 ptrOffset);
							break;
						case "ENGINE_VIEW":
							writer.WriteLine(
								"\t\tpublic static View {0} {{ get {{ return GetView({1}); }} set {{ SetObject({1}, value); }} }}",
								 FixName(parts[1]),
								 ptrOffset);
							break;
						case "ENGINE_BMAP":

							break;
						case "ENGINE_MATERIAL":
							writer.WriteLine(
								"\t\tpublic static Material {0} {{ get {{ return GetMaterial({1}); }} set {{ SetObject({1}, value); }} }}",
								 FixName(parts[1]),
								 ptrOffset);
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
