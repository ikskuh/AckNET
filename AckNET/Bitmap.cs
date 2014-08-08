using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AckNET
{
	public sealed partial class Bitmap : EngineObject
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="fileName"></param>
		/// <remarks>bmap_create</remarks>
		public Bitmap(string fileName)
			: base(true, Native.NativeMethods.BmapCreate(fileName))
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
			: base(true, Native.NativeMethods.BmapCreateblack(width, height, format))
		{

		}

		internal Bitmap(IntPtr handle)
			: base(false, handle)
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
	}
}
