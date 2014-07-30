using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AckNET
{
	public static class Collision
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="from"></param>
		/// <param name="to"></param>
		/// <param name="flags"></param>
		/// <returns></returns>
		/// <remarks>c_trace</remarks>
		public static bool Trace(Vector from, Vector to, CollisionFlags flags)
		{
			return Trace(from, to, flags, out var dist);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="from"></param>
		/// <param name="to"></param>
		/// <param name="flags"></param>
		/// <param name="distance"></param>
		/// <returns></returns>
		/// <remarks>c_trace</remarks>
		public static bool Trace(Vector from, Vector to, CollisionFlags flags, out ackvar distance)
		{
			distance = Native.NativeMethods.CTrace(ref from, ref to, (ackvar)(int)flags);
			return (bool)distance;
		}
	}
}
