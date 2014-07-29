using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AckNET
{
	public static class Level
	{
		public static void Load(string fileName)
		{
			Native.NativeMethods.LevelLoad(fileName);
		}

		public static void Free()
		{
			Native.NativeMethods.LevelFree();
		}

		public static void Mark()
		{
			Native.NativeMethods.LevelMark();
		}

		public static IEnumerable<Entity> GetEntities()
		{
			IntPtr ptr = IntPtr.Zero;
			do
			{
				ptr = Native.NativeMethods.EntNext(ptr);
				if (ptr != IntPtr.Zero)
					yield return new Entity(ptr);
			} while (ptr != IntPtr.Zero);
		}

	}
}
