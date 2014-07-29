using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AckNET
{
	public sealed class Contact : EngineObject
	{
		internal Contact(IntPtr handle)
			: base(false, handle)
		{

		}
	}
}
