using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace AckSharp
{
	public abstract partial class EngineObject
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

		/// <summary>
		/// Needed because old entity references would still be valid after level_load
		/// </summary>
		internal static void ClearEntityCache()
		{
			foreach (var obj in registry.ToArray())
			{
				var ent = obj.Value as Entity;
				if (ent == null) continue;
				registry.Remove(obj.Key);
			}
		}

		internal EngineObject(bool userCreated, IntPtr ptr)
		{
			if (ptr == IntPtr.Zero)
				throw new ArgumentException("Cannot create an object with an invalid pointer.");

			if (IsUserCreated && registry.ContainsKey(ptr))
			{
				throw new InvalidOperationException("You are not allowed mark an EngineObject as user created object and initialize it with a already registered EngineObject pointer.");
			}

			this.IsUserCreated = userCreated;
			this.InternalPointer = ptr;

			if (IsUserCreated)
			{
				// Register this object so we get a reference equality.
				registry.Add(ptr, this);
			}
		}

		public IntPtr InternalPointer
		{
			get; protected set;
		}

		public bool IsUserCreated { get; private set; }

		/// <summary>
		/// Removes this object. Only allowed if the object is user created.
		/// </summary>
		/// <remarks>ptr_remove</remarks>
		public void Remove()
		{
			CheckValid();
			Native.NativeMethods.PtrRemove(this);
			this.InternalPointer = IntPtr.Zero;
		}

		public static implicit operator IntPtr(EngineObject obj)
		{
			if (obj == null)
				return IntPtr.Zero;
			else
				return obj.InternalPointer;
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
		protected void Set(int offset, EngineObject ent)
		{
			CheckValid();
			IntPtr ptr = ent != null ? ent.InternalPointer : IntPtr.Zero;
			Marshal.WriteIntPtr(InternalPointer + offset, ptr);
		}

		protected T Get<T>(int offset)
			where T : EngineObject
		{
			CheckValid();
			var dref = Marshal.ReadIntPtr(InternalPointer + offset);
			if (dref != IntPtr.Zero)
				return EngineObject.Get<T>(dref);
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


		protected void SetString(int offset, NativeString str, string value)
		{
			CheckValid();
			str.Update(value);
			Marshal.WriteIntPtr(InternalPointer + offset, str.Pointer);
		}

		protected Delegate GetEvent(int offset, ref NativeEvent ne, Type type)
		{
			var ptr = GetPtr(offset);
			if (ne.Pointer == ptr)
				return ne.Delegate;
			ne.Delegate = Marshal.GetDelegateForFunctionPointer(ptr, type);
			return ne.Delegate;
		}

		protected void SetEvent(int offset, ref NativeEvent ne, Delegate ev)
		{
			if (ne.Delegate != ev)
			{
				ne.Delegate = ev;
				ne.Pointer = Marshal.GetFunctionPointerForDelegate(ev);
			}
			SetPtr(offset, ne.Pointer);
		}

		//public static bool operator ==(EngineObject a, EngineObject b)
		//{
		//	if ((object)a == null && (object)b == null) return true;
		//	if ((object)a == null || (object)b == null) return false;
		//	return a.Equals(b);
		//}
		//public static bool operator !=(EngineObject a, EngineObject b)
		//{
		//	if ((object)a == null && (object)b == null) return true;
		//	if ((object)a == null || (object)b == null) return false;
		//	return !a.Equals(b);
		//}

		//public bool Equals(EngineObject other)
		//{
		//	if (other == null) return false;
		//	return other.InternalPointer == this.InternalPointer;
		//}

		//public override bool Equals(object obj)
		//{
		//	return this.Equals(obj as EngineObject);
		//}

		/// <summary>
		/// Checks if the entity is valid.
		/// </summary>
		public void CheckValid()
		{
			if (!this.IsValid)
				throw new InvalidOperationException("Cannot access an invalid entity.");
		}

		public bool IsValid { get { return this.InternalPointer != IntPtr.Zero; } }

		public override int GetHashCode()
		{
			return this.InternalPointer.ToInt32();
		}

		public override string ToString()
		{
			return this.GetType().Name + "[" + this.InternalPointer + "]";
		}

		protected struct NativeEvent
		{
			public IntPtr Pointer;
			public Delegate Delegate;
		}

		protected class NativeString
		{
			public IntPtr Pointer { get; private set; }
			public int Length { get; private set;  }

			public NativeString()
			{
				this.Length = 0;
				this.Pointer = IntPtr.Zero;

				this.Update(new string('\0', 128));
			}

			~NativeString()
			{
				Marshal.FreeHGlobal(this.Pointer);
			}

			public void Update(string value)
			{
				if (value.Length >= this.Length)
				{
					// We don't have enough space for string + '\0'
					if (this.Pointer != IntPtr.Zero) Marshal.FreeHGlobal(this.Pointer);
					this.Length = value.Length + 1;
					this.Pointer = Marshal.AllocHGlobal(this.Length);
				}

				var text = Encoding.ASCII.GetBytes(value).Concat(new byte[] { 0 }).ToArray();
				memcpy(this.Pointer, text, text.Length);
			}

			[DllImport("msvcrt.dll", EntryPoint = "memcpy", CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
			private static extern IntPtr memcpy(IntPtr dest, byte[] source, int length);
		}
	}
}
