using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace AckNET
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

		public override string ToString()
		{
			return string.Format("({0}; {1}; {2})", X, Y, Z);
		}
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

		public override string ToString()
		{
			return string.Format("{{{0}; {1}; {2}}}", Pan, Tilt, Roll);
		}
	}
}
