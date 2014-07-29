using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AckNET
{
	public sealed partial class AckString : EngineObject
	{
		public AckString(string initalValue)
			: base(true, Native.NativeMethods.StrCreate(initalValue))
		{

		}

		public AckString(IntPtr handle)
			: base(false, handle)
		{

		}

		/// <summary>
		/// Copies the value into the string.
		/// </summary>
		/// <param name="value"></param>
		public void SetString(string value)
		{
			Native.NativeMethods.StrCpy(this.InternalPointer, value);
        }

		public ackvar GetWidth(Font font)
		{
			return Native.NativeMethods.StrWidth(this.Chars, font);
        }
	}
}
