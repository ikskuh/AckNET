using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AckSharp
{
	public static class Video
	{
		public static bool Set(int width, int height, bool? fullscreen)
		{
			int f = 0;
			if (fullscreen != null)
				f = fullscreen.Value ? 1 : 2;
			return (bool)Native.NativeMethods.VideoSet(width, height, 32, f);
		}

		public static bool Switch(int mode, ScreenMode screenMode)
		{
			return (bool)Native.NativeMethods.VideoSwitch(mode, 0, (int)screenMode);
		}
	}

	public enum ScreenMode
	{
		None = 0,
		Fullscreen = 1,
		Windowed = 2,
		OnlyChangeScreenSize = 4,
		Force4to3 = 8
	}
}
