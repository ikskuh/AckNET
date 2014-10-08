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

		/// <summary>
		/// 
		/// </summary>
		/// <param name="fileName"></param>
		/// <param name="flags"></param>
		/// <param name="layer"></param>
		/// <remarks>ent_createlayer</remarks>
		public Entity(string fileName, EntityFlags2 flags, double layer) :
			base(true, Native.NativeMethods.EntCreatelayer(fileName, (int)flags, layer))
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
			CheckValid();
			return new Bitmap(Native.NativeMethods.EntGetskin(this.InternalPointer, id));
		}

		/// <summary>
		///
		/// </summary>
		/// <param name="id"></param>
		/// <param name="skin"></param>
		/// <remarks>ent_setskin</remarks>
		public void SetSkin(int id, Bitmap skin)
		{
			CheckValid();
			Native.NativeMethods.EntSetskin(this.InternalPointer, skin, id);
		}

		/// <summary>
		/// Animates the entity.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="progress"></param>
		/// <param name="mode"></param>
		/// <remarks>ent_animate</remarks>
		public void Animate(string name, double progress, AnimationMode mode)
		{
			CheckValid();
			Native.NativeMethods.EntAnimate(this, name, progress, (int)mode);
		}

		public override string ToString()
		{
			if (this.IsValid)
				return (this.FileName ?? "<NULL>") + " @ " + this.Position.ToString();
			else
				return "Invalid Entity.";
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
				CheckValid();
				return (EntityType)(int)Native.NativeMethods.EntType(this);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <remarks>c_updatehull</remarks>
		public void UpdateHull()
		{
			Native.NativeMethods.CUpdatehull(this, this.Frame);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <remarks>c_updatehull</remarks>
		/// <param name="frame"></param>
		public void UpdateHull(ackvar frame)
		{
			Native.NativeMethods.CUpdatehull(this, frame);
		}
	}

	[Flags]
	public enum AnimationMode
	{
		None = 0,
		Cycle = (1 << 0),
		Add = (1 << 1),
		Skip = (1 << 2)
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