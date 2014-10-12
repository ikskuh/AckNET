using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AckSharp
{
	public static class MathHelper
	{
		static ThreadLocal<Random> rng = new ThreadLocal<Random>(() => new Random());

		/// <summary>
		/// Clamps a value into boundaries
		/// </summary>
		/// <param name="value"></param>
		/// <param name="min"></param>
		/// <param name="max"></param>
		/// <returns></returns>
		public static double Clamp(this double value, double min, double max)
		{
			return Math.Max(min, Math.Min(max, value));
		}

		/// <summary>
		/// Clamps a value into boundaries
		/// </summary>
		/// <param name="value"></param>
		/// <param name="min"></param>
		/// <param name="max"></param>
		/// <returns></returns>
		public static double Clamp(this ackvar value, double min, double max)
		{
			return Math.Max(min, Math.Min(max, value));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="speed"></param>
		/// <param name="acceleration"></param>
		/// <param name="friction"></param>
		/// <remarks>accelerate</remarks>
		/// <returns></returns>
		public static double Accelerate(ref double speed, double acceleration, double friction)
		{
			ackvar spd = speed;
			var dist = Native.NativeMethods.Accelerate(ref spd, acceleration, friction);
			speed = spd;
			return dist;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="speed"></param>
		/// <param name="acceleration"></param>
		/// <param name="friction"></param>
		/// <remarks>accelerate</remarks>
		/// <returns></returns>
		public static double Accelerate(ref ackvar speed, double acceleration, double friction)
		{
			var dist = Native.NativeMethods.Accelerate(ref speed, acceleration, friction);
			return dist;
		}

		/// <summary>
		/// Gets a random value between min and max.
		/// </summary>
		/// <param name="min"></param>
		/// <param name="max"></param>
		/// <returns></returns>
		public static double Random(double min, double max)
		{
			return min + (max - min) * rng.Value.NextDouble();
		}
	}
}
