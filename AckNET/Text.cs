using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AckNET
{
	public class Text : EngineObject
	{
		public Text(ackvar stringCount, ackvar layer)
			: base(true, Native.NativeMethods.TxtCreate(stringCount, layer))
		{

		}

		internal Text(IntPtr handle)
			:base(false, handle)
		{

		}
	}
}
