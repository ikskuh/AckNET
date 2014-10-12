using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AckSharp
{
	public sealed partial class Panel : EngineObject
	{
		internal Panel(IntPtr handle)
			:base(ObjectType.Panel, false, handle)
		{

		}

		public Panel(int layer) : 
			base(ObjectType.Panel, true, Native.NativeMethods.PanCreate("", layer))
		{

		}
	}
}
