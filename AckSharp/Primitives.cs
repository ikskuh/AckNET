using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace AckSharp
{
	[StructLayout(LayoutKind.Sequential)]
	public struct Vector
	{
		public ackvar X;
		public ackvar Y;
		public ackvar Z;

		public Vector(ackvar x, ackvar y)
			: this(x, y, 0.0)
		{
		}


		public Vector(ackvar x, ackvar y, ackvar z)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
		}

		public static Vector Add(Vector a, Vector b)
		{
			return new Vector(
				a.X + b.X,
				a.Y + b.Y,
				a.Z + b.Z);
		}

		public static Vector Subtract(Vector a, Vector b)
		{
			return new Vector(
				a.X - b.X,
				a.Y - b.Y,
				a.Z - b.Z);
		}

		public static Vector Multiply(Vector a, Vector b)
		{
			return new Vector(
				a.X * b.X,
				a.Y * b.Y,
				a.Z * b.Z);
		}

		public static Vector Scale(Vector a, double scalar)
		{
			return new Vector(
				a.X * scalar,
				a.Y * scalar,
				a.Z * scalar);
		}

		public static Vector operator +(Vector a, Vector b)
		{
			return Add(a, b);
		}

		public static Vector operator -(Vector a, Vector b)
		{
			return Subtract(a, b);
		}

		public static Vector operator *(Vector a, Vector b)
		{
			return Multiply(a, b);
		}
		public static Vector operator *(Vector a, double scalar)
		{
			return Scale(a, scalar);
		}

		public static Vector operator *(double scalar, Vector a)
		{
			return Scale(a, scalar);
		}

		public override string ToString()
		{
			return string.Format("({0}; {1}; {2})", X, Y, Z);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="view"></param>
		/// <returns></returns>
		/// <remarks>vec_to_screen</remarks>
		public Vector ToScreen(View view)
		{
			Vector vector = this;
			Native.NativeMethods.VecToScreen(ref vector, view);
			return vector;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="view"></param>
		/// <returns></returns>
		/// <remarks>vec_for_screen</remarks>
		public Vector ForScreen(View view)
		{
			Vector vector = this;
			Native.NativeMethods.VecForScreen(ref vector, view);
			return vector;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="view"></param>
		/// <returns></returns>
		/// <remarks>rel_to_screen</remarks>
		public Vector ToRelativeScreen(View view)
		{
			Vector vector = this;
			Native.NativeMethods.RelToScreen(ref vector, view);
			return vector;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="view"></param>
		/// <returns></returns>
		/// <remarks>rel_for_screen</remarks>
		public Vector ForRelativeScreen(View view)
		{
			Vector vector = this;
			Native.NativeMethods.RelForScreen(ref vector, view);
			return vector;
		}

		/// <summary>
		/// Normalizes a vector to length 1.
		/// </summary>
		/// <returns></returns>
		/// <remarks>vec_normalize</remarks>
		public Vector Normalize()
		{
			return this.Normalize(1.0);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="length"></param>
		/// <returns></returns>
		/// <remarks>vec_normalize</remarks>
		public Vector Normalize(ackvar length)
		{
			Vector vec = this;
			Native.NativeMethods.VecNormalize(ref vec, length);
			return vec;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		/// <remarks>vec_length</remarks>
		public ackvar Length
		{
			get { return Native.NativeMethods.VecLength(ref this); }
		}

		#region FluidInterface

		public Vector SetX(ackvar x)
		{
			return new Vector(x, this.Y, this.Z);
		}
		public Vector SetY(ackvar y)
		{
			return new Vector(this.X, y, this.Z);
		}

		public Vector SetZ(ackvar z)
		{
			return new Vector(this.X, this.Y, z);
		}
		public Vector AddX(ackvar x)
		{
			return new Vector(this.X + x, this.Y, this.Z);
		}
		public Vector AddY(ackvar y)
		{
			return new Vector(this.X, this.Y + y, this.Z);
		}

		public Vector AddZ(ackvar z)
		{
			return new Vector(this.X, this.Y, this.Z + z);
		}

		#endregion

		/// <summary>
		/// 
		/// </summary>
		/// <param name="from"></param>
		/// <param name="to"></param>
		/// <param name="factor"></param>
		/// <returns></returns>
		/// <remarks>vec_lerp</remarks>
		public static Vector Lerp(Vector from, Vector to, ackvar factor)
		{
			Vector vec = new Vector();
			Native.NativeMethods.VecLerp(ref vec, ref from, ref to, factor);
			return vec;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		/// <remarks>vec_dist</remarks>
		public static ackvar Distance(Vector a, Vector b)
		{
			return Native.NativeMethods.VecDist(ref a, ref b);
		}

		/// <summary>
		/// Gets the 2D distance of the xy-plane. Z component is ignored.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <remarks>vec_dist</remarks>
		/// <returns></returns>
		public static ackvar Distance2D(Vector a, Vector b)
		{
			a.Z = 0;
			b.Z = 0;
			return Native.NativeMethods.VecDist(ref a, ref b);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <remarks>vec_to_angle</remarks>
		/// <returns></returns>
		public Angle ToAngle()
		{
			Angle result = new Angle();
			Native.NativeMethods.VecToAngle(ref result, ref this);
			return result;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <remarks>vec_cross</remarks>
		/// <returns></returns>
		public static Vector Cross(Vector left, Vector right)
		{
			Vector result = new Vector();
			Native.NativeMethods.VecCross(ref result, ref left, ref right);
			return result;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="value"></param>
		/// <param name="angle"></param>
		/// <remarks>vec_rotate</remarks>
		/// <returns></returns>
		public static Vector Rotate(Vector value, Angle angle)
		{
			Native.NativeMethods.VecRotate(ref value, ref angle);
			return value;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="speed"></param>
		/// <param name="accel"></param>
		/// <param name="friction"></param>
		/// <remarks>vec_accelerate</remarks>
		/// <returns></returns>
		public static Vector Accelerate(ref Vector speed, Vector accel, double friction)
		{
			Vector result = new Vector();
			Native.NativeMethods.VecAccelerate(ref result, ref speed, ref accel, friction);
			return result;
		}

		public static Vector UnitX { get { return new Vector(1, 0, 0); } }
		public static Vector UnitY { get { return new Vector(0, 1, 0); } }
		public static Vector UnitZ { get { return new Vector(0, 0, 1); } }
		public static Vector One { get { return new Vector(1, 1, 1); } }
		public static Vector Zero { get { return new Vector(0, 0, 0); } }

	}

	[StructLayout(LayoutKind.Sequential)]
	public partial struct Color
	{
		public ackvar B;
		public ackvar G;
		public ackvar R;

		public Color(ackvar red, ackvar green, ackvar blue)
		{
			this.R = red;
			this.B = blue;
			this.G = green;
		}

		public static explicit operator Color(Vector vector)
		{
			return new Color(vector.Z, vector.Y, vector.X);
		}

		public static explicit operator Vector(Color color)
		{
			return new Vector(color.B, color.G, color.R);
		}

		public override string ToString()
		{
			return string.Format("[{0}; {1}; {2}]", R, G, B);
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct Angle
	{
		public ackvar Pan;
		public ackvar Tilt;
		public ackvar Roll;

		public Angle(ackvar pan, ackvar tilt)
			: this(pan, tilt, 0.0)
		{
		}

		public Angle(ackvar pan, ackvar tilt, ackvar roll)
		{
			this.Pan = pan;
			this.Tilt = tilt;
			this.Roll = roll;
		}

		public static explicit operator Angle(Vector vector)
		{
			return new Angle(vector.X, vector.Y, vector.Z);
		}

		public static explicit operator Vector(Angle angle)
		{
			return new Vector(angle.Pan, angle.Tilt, angle.Roll);
		}

		/// <summary>
		/// Converts the angle into a directional vector.
		/// </summary>
		/// <remarks>vec_for_angle</remarks>
		/// <returns></returns>

		public Vector ToVector()
		{
			Vector result = new Vector();
			Native.NativeMethods.VecForAngle(ref result, ref this);
			return result;
		}

		public override string ToString()
		{
			return string.Format("{{{0}; {1}; {2}}}", Pan, Tilt, Roll);
		}
	}
}
