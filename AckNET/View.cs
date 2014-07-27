﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AckNET
{
	public sealed partial class View : EngineObject
	{
		public View(ackvar layer)
			: base(true)
		{
			this.InternalPointer = Native.NativeMethods.ViewCreate(layer);
        }

		public View(IntPtr handle)
			 : base(false)
		{
			this.InternalPointer = handle;
		}

		public bool Check(Vector vMin, Vector vMax)
		{
			return (bool)Native.NativeMethods.ViewCheck(this.InternalPointer, ref vMax, ref vMax);
		}

		public ackvar ToLight(ackvar num, ackvar mode)
		{
			return Native.NativeMethods.ViewToLight(this.InternalPointer, num, mode);
		}

		// TODO: view_to_matrix
		// TODO: view_to_split
	}
}