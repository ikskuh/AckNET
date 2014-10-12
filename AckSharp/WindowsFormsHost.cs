using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GdiBitmap = System.Drawing.Bitmap;
using GdiColor = System.Drawing.Color;
using GdiGraphics = System.Drawing.Graphics;
using AckBitmap = AckSharp.Bitmap;
using AckGraphics = AckSharp.Graphics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace AckSharp
{
	public sealed class WindowsFormsHost
	{
		System.Windows.Forms.Panel root;
		GdiBitmap renderSource;
		AckBitmap renderTarget;
		bool refresh = false;

		public WindowsFormsHost(int width, int height)
		{
			renderSource = new GdiBitmap(1024, 768);
			renderTarget = new AckBitmap(1024, 768, 8888);

			this.root = new System.Windows.Forms.Panel();
			this.root.Size = new Size(width, height);
			this.root.Paint += Root_Paint;
			this.root.CreateControl();
			SetParent(this.root.Handle, EngineVars.HWnd);

			refresh = true;
		}

		private void Root_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			refresh = true;
		}

		public void Render()
		{
			if (refresh == false)
			{
				return;
			}
			using (var g = GdiGraphics.FromImage(renderSource))
			{
				g.Clear(GdiColor.Transparent);
			}
			foreach (Control control in this.root.Controls)
			{
				control.DrawToBitmap(renderSource, control.Bounds);
			}

			int format = renderTarget.Lock();
			if (format == 8888)
			{
				var data = renderSource.LockBits(
					new Rectangle(0, 0, 1024, 768),
					System.Drawing.Imaging.ImageLockMode.ReadOnly,
					System.Drawing.Imaging.PixelFormat.Format32bppArgb);
				memcpy(renderTarget.FinalBits, data.Scan0, data.Stride * renderSource.Height);
				renderSource.UnlockBits(data);
			}
			renderTarget.Unlock();
			refresh = false;
		}

		/// <summary>
		/// Gets the control collection.
		/// </summary>
		/// <returns></returns>
		public System.Windows.Forms.Control.ControlCollection Controls
		{
			get { return this.root.Controls; }
		}

		/// <summary>
		/// Gets the Gdi render target.
		/// </summary>
		/// <returns></returns>
		public Bitmap Target
		{
			get
			{
				this.Render();
				return renderTarget;
			}
		}

		[DllImport("msvcrt.dll", EntryPoint = "memcpy", CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
		static extern IntPtr memcpy(IntPtr dest, IntPtr src, int count);

		[DllImport("user32.dll", SetLastError = true)]
		static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
	}
}
