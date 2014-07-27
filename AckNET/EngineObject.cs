using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace AckNET
{
	public partial class EngineObject
	{
		public IntPtr InternalPointer
		{
			get; protected set;
		}
	}
}
