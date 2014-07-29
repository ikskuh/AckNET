using System;

namespace AckNET
{
	public sealed partial class Font : EngineObject
	{
		public Font(string code)
			: base(true, Native.NativeMethods.FontCreate(code))
		{

		}

		internal Font(IntPtr handle)
			: base(false, handle)
		{

		}
	}
}