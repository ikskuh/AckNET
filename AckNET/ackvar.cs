namespace AckNET
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
		
		public static ackvar operator + (ackvar a, ackvar b)
		{
			return new ackvar(a.RawValue + b.RawValue);
		}

		public static ackvar operator *(ackvar a, ackvar b)
		{
			return (ackvar)((double)a * (double)b);
		}

		public static ackvar operator - (ackvar a, ackvar b)
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


		public static explicit operator ackvar (int @var)
		{
			return new ackvar(@var * 1024);
		}
		
		public static explicit operator ackvar (bool @var)
		{
			return new ackvar(@var ? 1024 : 0);
		}
		
		public static implicit operator ackvar (double @var)
		{
			return new ackvar((int)(@var * 1024.0));
		}

		public override string ToString()
		{
			return ((double)this).ToString();
		}
	}
}