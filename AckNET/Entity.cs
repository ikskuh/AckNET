using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AckNET
{
	public sealed partial class Entity : EngineObject
	{
		public Entity(string fileName, Vector position)
			 : base(true)
		{
			this.InternalPointer = AckNET.Native.NativeMethods.EntCreate(fileName, ref position, IntPtr.Zero);
		}

		public Entity(IntPtr reference)
			: base(false)
		{
			if (reference == IntPtr.Zero)
				throw new ArgumentException("Cannot create an entity with an invalid pointer.");
			this.InternalPointer = reference;
		}


		public Bitmap GetSkin(int id)
		{
			return new Bitmap(Native.NativeMethods.EntGetskin(this.InternalPointer, id));
		}
		public void GetSkin(int id, Bitmap skin)
		{
			Native.NativeMethods.EntSetskin(this.InternalPointer, skin, id);
		}
	}
}
