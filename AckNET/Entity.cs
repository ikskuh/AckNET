using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AckNET
{
	public sealed partial class Entity : EngineObject
	{
		public Entity(IntPtr reference)
		{
			if (reference == IntPtr.Zero)
				throw new ArgumentException("Cannot create an entity with an invalid pointer.");
			this.InternalPointer = reference;
		}
	}
}
