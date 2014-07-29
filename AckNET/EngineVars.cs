using System;
using System.Runtime.InteropServices;

namespace AckNET
{
	public static partial class EngineVars
	{
		//private static EngineEventDelegate onMouseLeftPtr = null;
		//public static event EventHandler<EngineEventArgs> OnMouseLeftEvent;

		//internal static void InitializeEvents()
		//{
		//	onMouseLeftPtr = (x) =>
		//	{
		//		if (OnMouseLeftEvent != null)
		//			OnMouseLeftEvent(null, new EngineEventArgs(x));
		//		return 0.0;
		//	};
		//	SetEvent(2088, onMouseLeftPtr);
		//}

		private static ackvar GetVar(int offset, int delta = 0)
		{
			CheckValid();
			var dref = Marshal.ReadIntPtr(InternalPointer + offset);
			return new ackvar(Marshal.ReadInt32(dref + delta));
		}

		private static Vector GetVector(int offset)
		{
			CheckValid();
			return new Vector(
				GetVar(offset, 0),
				GetVar(offset, 4),
				GetVar(offset, 8));
		}

		private static void SetVar(int offset, ackvar @var, int delta = 0)
		{
			CheckValid();
			var dref = Marshal.ReadIntPtr(InternalPointer + offset);
			Marshal.WriteInt32(dref + delta, @var.RawValue);
		}

		private static void SetVector(int offset, Vector @var)
		{
			CheckValid();
			SetVar(offset, @var.X, 0);
			SetVar(offset, @var.Y, 4);
			SetVar(offset, @var.Z, 8);
		}

		private static void SetObject(int offset, EngineObject ent)
		{
			CheckValid();
			IntPtr ptr = ent != null ? ent.InternalPointer : IntPtr.Zero;
			Marshal.WriteIntPtr(InternalPointer + offset, ptr);
		}

		private static T Get<T>(int offset)
			where T : EngineObject
		{
			CheckValid();
			var dref = Marshal.ReadIntPtr(InternalPointer + offset);
			return EngineObject.Get<T>(dref);
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