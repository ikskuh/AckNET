using System;
using System.Runtime.InteropServices;

namespace AckNET
{
	public static partial class EngineVars
	{
		private static ackvar GetVar(int offset)
		{
			CheckValid();
			var dref = Marshal.ReadIntPtr(InternalPointer + offset);
			return new ackvar(Marshal.ReadInt32(dref));
		}
		private static void SetVar(int offset, ackvar @var)
		{
			CheckValid();
			var dref = Marshal.ReadIntPtr(InternalPointer + offset);
			Marshal.WriteInt32(dref, @var.RawValue);
		}

		private static Entity GetEntity(int offset)
		{
			CheckValid();
			var dref = Marshal.ReadIntPtr(InternalPointer + offset);
			if (dref != IntPtr.Zero)
				return new Entity(dref);
			else
				return null;
		}
		private static void SetEntity(int offset, Entity ent)
		{
			CheckValid();
			IntPtr ptr = ent != null ? ent.InternalPointer : IntPtr.Zero;
			Marshal.WriteIntPtr(InternalPointer + offset, ptr);
		}

		private static IntPtr GetPtr(int offset)
		{
			CheckValid();
			return Marshal.ReadIntPtr(InternalPointer + offset);
		}
		private static void SetPtr(int offset, IntPtr ptr)
		{
			CheckValid();
			Marshal.WriteIntPtr(InternalPointer + offset, ptr);
		}

		private static void SetEvent(int offset, EngineEventDelegate @event)
		{
			IntPtr ptr = IntPtr.Zero;
			if (@event != null)
				ptr = Marshal.GetFunctionPointerForDelegate(@event);
			var dref = Marshal.ReadIntPtr(InternalPointer + offset);
			Marshal.WriteIntPtr(dref, ptr);
		}

		private static void CheckValid()
		{
			if (InternalPointer == IntPtr.Zero)
				throw new InvalidOperationException("Cannot use engine vars with uninitialized engine.");
		}

		/// <summary>
		/// Gets the pointer returned by engine_open.
		/// </summary>
		/// <returns></returns>
		public static IntPtr InternalPointer
		{
			get; internal set;
		}
	}
}