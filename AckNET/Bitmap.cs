using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AckNET
{
	public sealed partial class Bitmap : EngineObject
	{
		public Bitmap(string fileName)
			: base(true)
		{
			this.InternalPointer = Native.NativeMethods.BmapCreate(fileName);
		}

		public Bitmap(int width, int height, int format)
			: base(true)
		{
			this.InternalPointer = Native.NativeMethods.BmapCreateblack(width, height, format);
		}

		public Bitmap(IntPtr handle)
			: base(false)
		{
			this.InternalPointer = handle;
		}
		public void Fill(Color color, ackvar alpha)
		{
			Native.NativeMethods.BmapFill(this, ref color, alpha);
		}
	}
}
