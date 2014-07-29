using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AckNET
{
	public static class Level
	{
		/// <summary>
		/// 
		/// </summary>
		/// <remarks>level_load</remarks>
		public static void Load(string fileName)
		{
			// Clear cache:
			// Needed because old entity references would still be valid after level_load
			EngineObject.ClearEntityCache();
			Native.NativeMethods.LevelLoad(fileName);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <remarks>level_free</remarks>
		public static void Free()
		{
			Native.NativeMethods.LevelFree();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <remarks>level_mark</remarks>
		public static void Mark()
		{
			Native.NativeMethods.LevelMark();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		/// <remarks>ent_next</remarks>
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
