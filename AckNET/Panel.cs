using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AckNET
{
	public sealed class Panel : EngineObject
	{
		internal Panel(IntPtr handle)
			:base(false, handle)
		{

		}
	}
}
