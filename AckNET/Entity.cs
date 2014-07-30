using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AckNET
{
	public sealed partial class Entity : EngineObject
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="fileName"></param>
		/// <param name="position"></param>
		/// <remarks>ent_create</remarks>
		public Entity(string fileName, Vector position)
			 : base(true, Native.NativeMethods.EntCreate(fileName, ref position, IntPtr.Zero))
		{

		}

		internal Entity(IntPtr reference)
			: base(false, reference)
		{

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		/// <remarks>ent_getskin</remarks>
		public Bitmap GetSkin(int id)
		{
			return new Bitmap(Native.NativeMethods.EntGetskin(this.InternalPointer, id));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <param name="skin"></param>
		/// <remarks>ent_setskin</remarks>
		public void GetSkin(int id, Bitmap skin)
		{
			Native.NativeMethods.EntSetskin(this.InternalPointer, skin, id);
		}

		public override string ToString()
		{
			return (this.FileName ?? "<NULL>") + " @ " + this.Position.ToString();
		}

		/// <summary>
		/// Returns the type of this entity.
		/// </summary>
		/// <returns></returns>
		/// <remarks>ent_type</remarks>
		public EntityType Type
		{
			get
			{
				return (EntityType)(int)Native.NativeMethods.EntType(this);
			}
		}
	}

	public enum EntityType
	{
		Invalid = 0, // Kein gültiger Typus
		PolygonBasedBSPMap = 1,	// Polygon-basierende BSP-Map (A4, A5, A6)
		MeshBasedABTMap = 2, // Mesh-basierende ABT-Map (A7)
		MeshBasedBSPMap = 3, // Mesh-basierende BSP-Map (A7)
		Terrain = 4, // Terrain
		Modell = 5,	// Modell
		Sprite = 6,	// Sprite
	}
}
