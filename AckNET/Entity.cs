using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AckNET
{
	public sealed partial class Entity : EngineObject
	{
		public Entity(string fileName, Vector position)
			 : base(true, Native.NativeMethods.EntCreate(fileName, ref position, IntPtr.Zero))
		{

		}

		internal Entity(IntPtr reference)
			: base(false, reference)
		{
			
		}


		public Bitmap GetSkin(int id)
		{
			return new Bitmap(Native.NativeMethods.EntGetskin(this.InternalPointer, id));
		}
		public void GetSkin(int id, Bitmap skin)
		{
			Native.NativeMethods.EntSetskin(this.InternalPointer, skin, id);
		}

		public override string ToString()
		{
			return (this.Type ?? "<NULL>") + " @ " + this.Position.ToString();
		}
	}
}
