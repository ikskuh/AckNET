using System;

namespace AckNET
{
	public sealed partial class Font : EngineObject
	{
		public Font(string code)
			: base(true)
		{
			this.InternalPointer = Native.NativeMethods.FontCreate(code);
		}

		public Font(IntPtr handle)
			: base(false)
		{
			this.InternalPointer = handle;
		}
	}
}