using System;
using System.Runtime.InteropServices;

namespace AckNET
{
	public static class Acknex
	{
		public static bool Close()
		{
			return engine_close() != 0;
		}

		public static bool Frame()
		{
			return engine_frame() != 0;
		}

		public static bool Open(string commandLine)
		{
			EngineVars.InternalPointer = engine_open(commandLine, 0);
			if (EngineVars.InternalPointer != IntPtr.Zero)
			{
				EngineVars.InitializeEvents();
			}
			return EngineVars.InternalPointer != IntPtr.Zero;
        }

		[DllImport("acknex.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
		private static extern int engine_close();

		[DllImport("acknex.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
		private static extern int engine_frame();

		[DllImport("acknex.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr engine_open(string commandLine, int callback);
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
	public delegate ackvar EngineEventDelegate(ackvar param);
}