using System;

namespace AckSharp
{
	public struct ackvar
	{
		/// <summary>
		/// Gets or sets the raw value.
		/// </summary>
		public int RawValue;

		public ackvar(int raw)
		{
			this.RawValue = raw;
		}

		public T To<T>()
			where T : EngineObject
		{
			return EngineObject.Get<T>(this.ToIntPtr());
		}

		public IntPtr ToIntPtr()
		{
			return new IntPtr(this.RawValue);
		}

		public static ackvar operator +(ackvar a, ackvar b)
		{
			return new ackvar(a.RawValue + b.RawValue);
		}

		public static ackvar operator *(ackvar a, ackvar b)
		{
			return (ackvar)((double)a * (double)b);
		}

		public static ackvar operator -(ackvar a, ackvar b)
		{
			return new ackvar(a.RawValue - b.RawValue);
		}

		public static explicit operator int (ackvar @var)
		{
			return @var.RawValue / 1024;
		}

		public static explicit operator bool (ackvar @var)
		{
			return @var.RawValue != 0;
		}

		public static implicit operator double (ackvar @var)
		{
			return @var.RawValue / 1024.0;
		}


		public static explicit operator ackvar(int @var)
		{
			return new ackvar(@var * 1024);
		}

		public static explicit operator ackvar(bool @var)
		{
			return new ackvar(@var ? 1024 : 0);
		}

		public static implicit operator ackvar(double @var)
		{
			return new ackvar((int)(@var * 1024.0));
		}

		public override string ToString()
		{
			return ((double)this).ToString();
		}

		/// <summary>
		/// Generates an ackvar with the bit representation of a float.
		/// </summary>
		/// <param name="value"></param>
		/// <remarks>floatv</remarks>
		/// <returns></returns>
		public static ackvar Float(float value)
		{
			var bits = BitConverter.GetBytes(value);
			return new ackvar(BitConverter.ToInt32(bits, 0));
		}

		/// <summary>
		/// Generates an ackvar with the bit representation of a float.
		/// </summary>
		/// <param name="value"></param>
		/// <remarks>floatv</remarks>
		/// <returns></returns>
		public static ackvar Float(double value)
		{
			return ackvar.Float((float)value);
		}

		/// <summary>
		/// Generates an ackvar with the bit representation of a float.
		/// </summary>
		/// <param name="value"></param>
		/// <remarks>floatv</remarks>
		/// <returns></returns>
		public static ackvar Float(ackvar value)
		{
			return ackvar.Float((double)value);
		}

		/// <summary>
		/// Generates an ackvar with the bit representation of an Int32
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static ackvar Int32(Int32 value)
		{
			var bits = BitConverter.GetBytes(value);
			return new ackvar(BitConverter.ToInt32(bits, 0));
		}

		/// <summary>
		/// Generates an ackvar with the bit representation of an Int32
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static ackvar UInt32(UInt32 value)
		{
			var bits = BitConverter.GetBytes(value);
			return new ackvar(BitConverter.ToInt32(bits, 0));
		}
	}
}