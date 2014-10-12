using System;

namespace AckSharp
{
	public sealed partial class Font : EngineObject
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="code"></param>
		/// <remarks>font_create</remarks>
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