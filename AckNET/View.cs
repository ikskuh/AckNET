using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AckNET
{
	public sealed partial class View : EngineObject
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="layer"></param>
		/// <remarks>view_create</remarks>
		public View(ackvar layer)
			: base(true, Native.NativeMethods.ViewCreate(layer))
		{

		}

		internal View(IntPtr handle)
			 : base(false, handle)
		{

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="vMin"></param>
		/// <param name="vMax"></param>
		/// <returns></returns>
		/// <remarks>view_check</remarks>
		public bool Check(Vector vMin, Vector vMax)
		{
			CheckValid();
			return (bool)Native.NativeMethods.ViewCheck(this.InternalPointer, ref vMax, ref vMax);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="num"></param>
		/// <param name="mode"></param>
		/// <returns></returns>
		/// <remarks>view_to_light</remarks>
		public ackvar ToLight(ackvar num, ackvar mode)
		{
			CheckValid();
			return Native.NativeMethods.ViewToLight(this.InternalPointer, num, mode);
		}

		// TODO: view_to_matrix
		// TODO: view_to_split
	}
}
