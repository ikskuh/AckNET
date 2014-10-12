using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace AckSharp
{
	/// <summary>
	/// Engine object link structure.
	/// </summary>
	public sealed class CLink : IEquatable<CLink>
	{
		private readonly IntPtr reference;

		/// <summary>
		/// Create a CLink by pointer
		/// </summary>
		/// <param name="next"></param>
		internal CLink(IntPtr next)
		{
			this.reference = next;
		}

		/// <summary>
		/// Gets the next object of a given type.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		public T As<T>()
			where T : EngineObject
		{
			return EngineObject.Get<T>(this.reference);
		}

		public bool Equals(CLink other)
		{
			if (other == null)
				return false;
			return this.reference == other.reference;
		}

		public override bool Equals(object obj)
		{
			return this.Equals(obj as CLink);
		}

		public override int GetHashCode()
		{
			return this.reference.ToInt32();
		}

		public override string ToString()
		{
			return this.Type.ToString() + " [" + this.reference.ToInt32().ToString("X") + "]";
		}

		public static bool operator ==(CLink a, CLink b)
		{
			if ((object)a == null && (object)b == null) return true;
			if ((object)a == null || (object)b == null) return false;
			return a.Equals(b);
		}

		public static bool operator !=(CLink a, CLink b)
		{
			return !(a == b);
		}

		/// <summary>
		/// Gets the unique object handle.
		/// </summary>
		/// <returns></returns>
		public int Handle
		{
			get { return Marshal.ReadInt32(this.reference, 0); }
		}

		/// <summary>
		/// Gets the next engine link.
		/// </summary>
		/// <returns></returns>
		public CLink Next
		{
			get
			{
				IntPtr ptr = Marshal.ReadIntPtr(this.reference, 4);
				if (ptr == IntPtr.Zero)
					return null;
				return new CLink(ptr);
			}
		}

		/// <summary>
		/// Gets the type of this object.
		/// </summary>
		/// <returns></returns>
		public ObjectType Type
		{
			get
			{
				return (ObjectType)BitConverter.GetBytes(this.Handle)[3];
			}
		}

		/// <summary>
		/// Gets the name of the linked object.
		/// </summary>
		/// <returns></returns>
		public string Name
		{
			get
			{
				IntPtr ptr = Marshal.ReadIntPtr(this.reference, 8);
				if (ptr == IntPtr.Zero)
					return null;
				return Marshal.PtrToStringAnsi(ptr);
			}
		}
	}

	/// <summary>
	/// Defines the type of an engine object.
	/// </summary>
	public enum ObjectType : byte
	{
		Invalid = 0xFF,
		String = 2,
		Entity = 4,
		EntityLocal = 5,
		EntityLayer = 8,
		Font = 11,
		Bitmap = 12,
		Material = 13,
		Sound = 14,
		Stream = 15,
		Text = 20,
		Panel = 21,
		View = 22,
		Particle = 23,
	}
}
