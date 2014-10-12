using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AckSharp
{
	public sealed partial class Bitmap : EngineObject
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="fileName"></param>
		/// <remarks>bmap_create</remarks>
		public Bitmap(string fileName)
			: base(ObjectType.Bitmap, true, Native.NativeMethods.BmapCreate(fileName))
		{

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="width"></param>
		/// <param name="height"></param>
		/// <param name="format"></param>
		/// <remarks>bmap_createblack</remarks>
		public Bitmap(int width, int height, int format)
			: base(ObjectType.Bitmap, true, Native.NativeMethods.BmapCreateblack(width, height, format))
		{

		}

		internal Bitmap(IntPtr handle)
			: base(ObjectType.Bitmap, false, handle)
		{

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="color"></param>
		/// <param name="alpha"></param>
		/// <remarks>bmap_fill</remarks>
		public void Fill(Color color, ackvar alpha)
		{
			CheckValid();
			Native.NativeMethods.BmapFill(this, ref color, alpha);
		}

		/// <summary>
		/// Locks the bitmap.
		/// </summary>
		/// <returns>Format of the locked image.</returns>
		public int Lock()
		{
			CheckValid();
			return (int)Native.NativeMethods.BmapLock(this, 0);
		}

		/// <summary>
		/// Unlocks the bitmap.
		/// </summary>
		public void Unlock()
		{
			CheckValid();
			Native.NativeMethods.BmapUnlock(this);
		}
	}
}
