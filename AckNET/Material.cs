using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AckNET
{
	public partial class Material : EngineObject
	{
		public Material()
			: base(true)
		{

		}

		public Material(IntPtr reference)
			: base(false)
		{
			if (reference == IntPtr.Zero)
				throw new ArgumentException("Cannot create an entity with an invalid pointer.");
			this.InternalPointer = reference;
		}
	}
}
