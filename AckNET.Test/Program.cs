using AckNET.EngineVars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AckNET.Test
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Acknex.AnalyzeWrapper();

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

			while (!(bool)KeyEsc)
			{
				if (ReferenceEquals(ent, EngineVars.MouseEnt))
				{
					ent.Pan += 1.5 * TimeStep;
				}

				Camera.Pan += (KeyCul - KeyCur) * TimeStep;

				yield return Wait.ForFrames(1);
			}
		}

		private static void EngineVars_OnMouseLeftEvent(object sender, EngineEventArgs e)
		{
			Console.WriteLine("Hey listen!");
		}
	}
}