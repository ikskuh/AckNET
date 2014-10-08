using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AckNET
{
	public sealed partial class Text : EngineObject
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="stringCount"></param>
		/// <param name="layer"></param>
		/// <remarks>txt_create</remarks>
		public Text(ackvar stringCount, ackvar layer)
			: base(true, Native.NativeMethods.TxtCreate(stringCount, layer))
		{

		}

		internal Text(IntPtr handle)
			: base(false, handle)
		{

		}
	}
}
