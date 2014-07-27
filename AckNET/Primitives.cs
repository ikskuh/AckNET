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
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct Color
	{
		public ackvar Blue;
		public ackvar Green;
		public ackvar Red;

		public Color(ackvar red, ackvar green, ackvar blue)
		{
			this.Red = red;
			this.Blue = blue;
			this.Green = green;
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct Angle
	{
		public ackvar Pan;
		public ackvar Tilt;
		public ackvar Roll;

		public Angle(ackvar pan, ackvar tilt, ackvar roll)
		{
			this.Pan = pan;
			this.Tilt = tilt;
			this.Roll = roll;
		}
	}
}
