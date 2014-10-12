using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AckSharp
{
	public sealed partial class Panel : EngineObject
	{
		internal Panel(IntPtr handle)
			:base(false, handle)
		{

		}

		public Panel(int layer) : 
			base(true, Native.NativeMethods.PanCreate("", layer))
		{

		}
	}
}
