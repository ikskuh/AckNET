using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AckSharp
{
	public sealed partial class Contact : EngineObject
	{
		internal Contact(IntPtr handle)
			: base(false, handle)
		{

		}
	}
}
