﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace AckNET
{
	public abstract partial class EngineObject : IEquatable<EngineObject>, IDisposable
	{
		protected EngineObject(bool userCreated)
		{

		}

		~EngineObject()
		{
			this.Dispose(false);
		}

		public IntPtr InternalPointer
		{
			get; protected set;
		}

		public static implicit operator IntPtr(EngineObject obj)
		{
			if (obj == null)
				return IntPtr.Zero;
			else
				return obj.InternalPointer;
		}

		protected virtual void Dispose(bool disposing) { }

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
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
			SetVar(offset + 0, value.Blue);
			SetVar(offset + 4, value.Green);
			SetVar(offset + 8, value.Red);
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

		protected Entity GetEntity(int offset)
		{
			CheckValid();
			var dref = Marshal.ReadIntPtr(InternalPointer + offset);
			if (dref != IntPtr.Zero)
				return new Entity(dref);
			else
				return null;
		}
		protected void SetEntity(int offset, Entity ent)
		{
			CheckValid();
			IntPtr ptr = ent != null ? ent.InternalPointer : IntPtr.Zero;
			Marshal.WriteIntPtr(InternalPointer + offset, ptr);
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
		protected void SetMaterial(int offset, Material ent)
		{
			CheckValid();
			IntPtr ptr = ent != null ? ent.InternalPointer : IntPtr.Zero;
			Marshal.WriteIntPtr(InternalPointer + offset, ptr);
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