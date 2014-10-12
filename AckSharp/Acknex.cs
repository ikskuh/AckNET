using ClrTest.Reflection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace AckSharp
{
	public static class Acknex
	{
		public static void AddFolder(string path)
		{
			Native.NativeMethods.AddFolder(path);
		}
		public static void AddResource(string path)
		{
			Native.NativeMethods.AddResource(path);
		}

		public static void AddNew()
		{
			Native.NativeMethods.AddNew();
		}

		public static bool Close()
		{
			return Native.NativeMethods.EngineClose() != 0;
		}

		public static void Run(SchedulableMethod mainMethod, string commandLine)
		{
			Acknex.Open(commandLine);

			Scheduler scheduler = new Scheduler();
			scheduler.Start(mainMethod);

			while (Acknex.Frame() && scheduler.Update()) ;

			Acknex.Close();
		}

		public static bool Frame()
		{
			return Native.NativeMethods.EngineFrame() != 0;
		}

		public static bool Open(string commandLine)
		{
			EngineVars.InternalPointer = Native.NativeMethods.EngineOpen(commandLine, 0);
			if (EngineVars.InternalPointer != IntPtr.Zero)
			{
				EngineVars.InitializeEvents();
			}
			return EngineVars.InternalPointer != IntPtr.Zero;
		}

		public static void Exit(string message)
		{
			Native.NativeMethods.SysExit(message);
		}

#if DEBUG

		public static void AnalyzeWrapper()
		{
			AnalyzeWrapper(Console.Out);
		}
		public static void AnalyzeWrapper(TextWriter writer)
		{
			HashSet<MethodBase> allMethods = new HashSet<MethodBase>();
			HashSet<MethodBase> methods = new HashSet<MethodBase>();
			foreach (var method in typeof(Native.NativeMethods).GetMethods(BindingFlags.Static | BindingFlags.Public))
			{
				methods.Add(method);
				allMethods.Add(method);
			}
			foreach (var type in typeof(Acknex).Assembly.GetTypes())
			{
				foreach (var method in type.GetMethods(BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
				{
					var mb = method.GetMethodBody();
					if (mb != null)
					{
						ILReader reader = new ILReader(method);
						foreach (var token in reader)
						{
							var instr = token as InlineMethodInstruction;
							if (instr != null)
							{
								if (allMethods.Contains(instr.Method))
								{
									methods.Remove(instr.Method);
									var attribs = instr.Method.GetCustomAttributes(typeof(DllImportAttribute), false) as DllImportAttribute[];
									if (attribs.Length == 1)
									{
										writer.WriteLine("{2} -> {0}.{1}", type.Name, method.Name, attribs[0].EntryPoint);
									}
									else
									{
										writer.WriteLine("{0}.{1}", type.Name, method.Name);
									}
								}
							}
						}
					}
				}
			}

			writer.WriteLine(
				"Wrapper Completeness: {0}/{1} = {2}%",
				(allMethods.Count - methods.Count),
				allMethods.Count,
				100 * (allMethods.Count - methods.Count) / allMethods.Count);
		}
#endif
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public delegate ackvar EngineEventDelegate(ackvar param);
}