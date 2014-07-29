using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AckNET
{
	public partial class Material : EngineObject
	{
		public Material()
			: base(true, Native.NativeMethods.MtlCreate())
		{

		}

		internal Material(IntPtr reference)
			: base(false, reference)
		{
		}
	}
}
