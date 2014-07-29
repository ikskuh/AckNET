using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace AckNET
{
	public abstract partial class EngineObject : IEquatable<EngineObject>
	{
		private static Dictionary<IntPtr, EngineObject> registry = new Dictionary<IntPtr, EngineObject>();

		public static T Get<T>(IntPtr ptr)
			where T : EngineObject
		{
			if (ptr == IntPtr.Zero)
				return null;
			if (registry.ContainsKey(ptr))
			{
				return registry[ptr] as T;
			}
			else
			{
				var type = typeof(T).GetConstructor(
					BindingFlags.Instance | BindingFlags.NonPublic,
					null,
					new[] { typeof(IntPtr) },
					null);

				var obj = type.Invoke(new object[] { ptr }) as T;
				registry.Add(ptr, obj);
				return obj;
			}
		}

		internal EngineObject(bool userCreated, IntPtr ptr)
		{
			if (ptr == IntPtr.Zero)
				throw new ArgumentException("Cannot create an entity with an invalid pointer.");

			if (IsUsedCreated && registry.ContainsKey(ptr))
			{
				throw new InvalidOperationException("You are not allowed mark an EngineObject as used created entity and initialize it with a already registered EngineObject pointer.");
			}

			this.IsUsedCreated = userCreated;
			this.InternalPointer = ptr;

			if (IsUsedCreated)
			{
				// Register this object so we get a reference equality.
				registry.Add(ptr, this);
			}
		}

		public IntPtr InternalPointer
		{
			get; protected set;
		}

		public bool IsUsedCreated { get;private set; }

		public static implicit operator IntPtr(EngineObject obj)
		{
			if (obj == null)
				return IntPtr.Zero;
			else
				return obj.InternalPointer;
		}

		protected void CheckValid()
		{
			if (InternalPointer == IntPtr.Zero)
				throw new InvalidOperationException("Cannot use engine vars with uninitialized engine.");
		}

		protected ackvar GetVar(int offset)
		{
			CheckValid();
			return new ackvar(Marshal.ReadInt32(InternalPointer + offset));
		}
		protected void SetVar(int offset, ackvar @var)
		{
			CheckValid();
			Marshal.WriteInt32(InternalPointer + offset, @var.RawValue);
		}

		protected Vector GetVector(int offset)
		{
			CheckValid();
			return new Vector(
				GetVar(offset + 0),
				GetVar(offset + 4),
				GetVar(offset + 8));
		}

		protected void SetVector(int offset, Vector value)
		{
			CheckValid();
			SetVar(offset + 0, value.X);
			SetVar(offset + 4, value.Y);
			SetVar(offset + 8, value.Z);
		}
		protected Angle GetAngle(int offset)
		{
			CheckValid();
			return new Angle(
				GetVar(offset + 0),
				GetVar(offset + 4),
				GetVar(offset + 8));
		}

		protected void SetAngle(int offset, Angle value)
		{
			CheckValid();
			SetVar(offset + 0, value.Pan);
			SetVar(offset + 4, value.Tilt);
			SetVar(offset + 8, value.Roll);
		}

		protected Color GetColor(int offset)
		{
			CheckValid();
			// Note: rgb constructor, bgr layout!
			return new Color(
				GetVar(offset + 8),
				GetVar(offset + 4),
				GetVar(offset + 0));
		}

		protected void SetColor(int offset, Color value)
		{
			CheckValid();
			SetVar(offset + 0, value.B);
			SetVar(offset + 4, value.G);
			SetVar(offset + 8, value.R);
		}

		protected int GetInt(int offset)
		{
			CheckValid();
			return Marshal.ReadInt32(InternalPointer + offset);
		}
		protected void SetInt(int offset, int @var)
		{
			CheckValid();
			Marshal.WriteInt32(InternalPointer + offset, @var);
		}

		protected float GetFloat(int offset)
		{
			CheckValid();
			return BitConverter.ToSingle(BitConverter.GetBytes(Marshal.ReadInt32(InternalPointer + offset)), 0);
		}
		protected void SetFloat(int offset, float @var)
		{
			CheckValid();
			Marshal.WriteInt32(InternalPointer + offset, BitConverter.ToInt32(BitConverter.GetBytes(@var), 0));
		}
		protected void SetObject(int offset, EngineObject ent)
		{
			CheckValid();
			IntPtr ptr = ent != null ? ent.InternalPointer : IntPtr.Zero;
			Marshal.WriteIntPtr(InternalPointer + offset, ptr);
		}

		protected Entity GetEntity(int offset)
		{
			CheckValid();
			var dref = Marshal.ReadIntPtr(InternalPointer + offset);
			if (dref != IntPtr.Zero)
				return new Entity(dref);
			else
				return null;
		}
		protected Bitmap GetBitmap(int offset)
		{
			CheckValid();
			var dref = Marshal.ReadIntPtr(InternalPointer + offset);
			if (dref != IntPtr.Zero)
				return new Bitmap(dref);
			else
				return null;
		}

		protected View GetView(int offset)
		{
			CheckValid();
			var dref = Marshal.ReadIntPtr(InternalPointer + offset);
			if (dref != IntPtr.Zero)
				return new View(dref);
			else
				return null;
		}

		protected Sound GetSound(int offset)
		{
			CheckValid();
			var dref = Marshal.ReadIntPtr(InternalPointer + offset);
			if (dref != IntPtr.Zero)
				return new Sound(dref);
			else
				return null;
		}

		protected Material GetMaterial(int offset)
		{
			CheckValid();
			var dref = Marshal.ReadIntPtr(InternalPointer + offset);
			if (dref != IntPtr.Zero)
				return new Material(dref);
			else
				return null;
		}

		protected IntPtr GetPtr(int offset)
		{
			CheckValid();
			return Marshal.ReadIntPtr(InternalPointer + offset);
		}
		protected void SetPtr(int offset, IntPtr ptr)
		{
			CheckValid();
			Marshal.WriteIntPtr(InternalPointer + offset, ptr);
		}
		protected string GetString(int offset)
		{
			CheckValid();
			return Marshal.PtrToStringAnsi(GetPtr(offset));
		}

		protected void SetEvent(int offset, EngineEventDelegate @event)
		{
			IntPtr ptr = IntPtr.Zero;
			if (@event != null)
				ptr = Marshal.GetFunctionPointerForDelegate(@event);
			Marshal.WriteIntPtr(InternalPointer + offset, ptr);
		}

		public static bool operator ==(EngineObject a, EngineObject b)
		{
			if ((object)a == null && (object)b == null) return true;
			if ((object)a == null || (object)b == null) return false;
			return a.Equals(b);
		}
		public static bool operator !=(EngineObject a, EngineObject b)
		{
			if ((object)a == null && (object)b == null) return true;
			if ((object)a == null || (object)b == null) return false;
			return !a.Equals(b);
		}

		public bool Equals(EngineObject other)
		{
			if (other == null) return false;
			return other.InternalPointer == this.InternalPointer;
		}

		public override bool Equals(object obj)
		{
			return this.Equals(obj as EngineObject);
		}

		public override int GetHashCode()
		{
			return this.InternalPointer.ToInt32();
		}

		public override string ToString()
		{
			return this.GetType().Name + "[" + this.InternalPointer + "]";
		}
	}
}
