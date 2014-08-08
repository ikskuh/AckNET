using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AckNET
{
	public sealed partial class AckString : EngineObject
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="initalValue"></param>
		/// <remarks>str_create</remarks>
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
		/// <remarks>str_cpy</remarks>
		public void SetString(string value)
		{
			CheckValid();
			Native.NativeMethods.StrCpy(this.InternalPointer, value);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="font"></param>
		/// <returns></returns>
		/// <remarks>str_width</remarks>
		public ackvar GetWidth(Font font)
		{
			CheckValid();
			return Native.NativeMethods.StrWidth(this.Chars, font);
		}
	}
}
