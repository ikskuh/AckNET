using AckNET.EngineVars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace AckNET.Test
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			using(var sr = new StreamWriter("../../../../documentation.txt"))
				Acknex.AnalyzeWrapper(sr);

			Application.EnableVisualStyles();

			Acknex.Run(MainMethod, "-nx 200");
		}

		private static IEnumerable<Wait> MainMethod()
		{
			OnTab += (s, e) => { Console.WriteLine("Pressed [TAB]"); };
			MouseMode = 3;

			Level.Load("");
			yield return Wait.ForFrames(1);
			EngineVars.SkyColor = Color.DeepSkyBlue;

			var ent = new Entity("cargo.mdl", new Vector(550.0, 0.0, 0.0));

			var snd = new Sound("beep.wav");

			OnSpace += (s, e) => { snd.Play(100, 0); };

			WindowsFormsHost host = new WindowsFormsHost(1024, 768);
			var tb = new TextBox()
			{
				Left = 120,
				Top = 120,
				Width = 80,
				Text = "Change me!"
			};
			host.Controls.Add(tb);

			var btn = new Button()
			{
				Left = 120,
				Top = 80,
				Width = 80,
				Height = 25,
				Text = "Click me!",
			};
			btn.Click += (s, e) => { MessageBox.Show(tb.Text); };

			host.Controls.Add(btn);

			while (!(bool)KeyEsc)
			{
				if (ReferenceEquals(ent, EngineVars.MouseEnt))
				{
					ent.Pan += 1.5 * TimeStep;
				}

				Camera.Pan += (KeyCul - KeyCur) * TimeStep;

				Graphics.DrawQuad(
					host.Target,
					new Vector(0, 0, 0),
					null,
					null,
					null,
					null,
					100,
					0);

				yield return Wait.ForFrames(1);
			}
		}

		private static void EngineVars_OnMouseLeftEvent(object sender, EngineEventArgs e)
		{
			Console.WriteLine("Hey listen!");
		}
	}
}