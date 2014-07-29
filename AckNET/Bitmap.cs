using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AckNET
{
	public sealed partial class Bitmap : EngineObject
	{
		public Bitmap(string fileName)
			: base(true, Native.NativeMethods.BmapCreate(fileName))
		{

		}

		public Bitmap(int width, int height, int format)
			: base(true, Native.NativeMethods.BmapCreateblack(width, height, format))
		{

		}

		internal Bitmap(IntPtr handle)
			: base(false, handle)
		{
			
		}
		public void Fill(Color color, ackvar alpha)
		{
			Native.NativeMethods.BmapFill(this, ref color, alpha);
		}
	}
}
