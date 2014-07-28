using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AckNET
{
	public static class Graphics
	{
		public static void DrawLine(Vector from, Color? color, ackvar alpha)
		{
			if(color != null)
			{
				var c = color.Value;
				Native.NativeMethods.DrawLine(ref from, ref c, alpha);
			}
			else
			{
				Native.NativeMethods.DrawLine(ref from, IntPtr.Zero, alpha);
			}
		}

		public static void DrawLine3D(Vector from, Color? color, ackvar alpha)
		{
			if (color != null)
			{
				var c = color.Value;
				Native.NativeMethods.DrawLine3d(ref from, ref c, alpha);
			}
			else
			{
				Native.NativeMethods.DrawLine3d(ref from, IntPtr.Zero, alpha);
			}
		}

		public static void DrawPoint3D(Vector position, Color color, ackvar alpha, ackvar size)
		{
			Native.NativeMethods.DrawPoint3d(ref position, ref color, alpha, size);
		}

		public static void DrawBox3D(Vector vMin, Vector vMax, Color color, ackvar alpha)
		{
			Native.NativeMethods.DrawBox3d(ref vMin, ref vMax, ref color, alpha);
		}

		public static void DrawObject(EngineObject @object)
		{
			Native.NativeMethods.DrawObj(@object);
		}

		public static void DrawBegin()
		{
			Native.NativeMethods.DrawBegin();
		}

		public static void DrawQuad(Bitmap bitmap, Vector position, Vector? offset, Vector? size, Vector? scale, Color? color, ackvar alpha, ackvar angle)
		{
			Vector vOffset = offset ?? new Vector(0, 0, 0);
			Vector vSize = size ?? new Vector(bitmap.Width, bitmap.Height);
			Vector vScale = scale ?? new Vector(1, 1);
			Color vColor = color ?? new Color(255, 255, 255);

			Native.NativeMethods.DrawQuad(
				bitmap,
				ref position,
				ref vOffset,
				ref vSize,
				ref vScale,
				ref vColor,
				alpha,
				angle);
		}

		public static void DrawText(string text, ackvar x, ackvar y, Color color)
		{
			Native.NativeMethods.DrawText(text, x, y, ref color);
		}

		public static void TextMode(string fontName, FontMode mode, ackvar height, ackvar alpha)
		{
			Native.NativeMethods.DrawTextmode(fontName, (ackvar)(int)mode, height, alpha);
		}

		public static bool SetRenderTarget(Bitmap bitmap, ackvar num, ackvar mode)
		{
			return (bool)Native.NativeMethods.BmapRendertarget(bitmap, num, mode);
		}
	}

	public enum FontMode
	{
		Default = 0,
		Bold = 1,
		Italic = 2,
		BoldItalic = 3
	}
}
