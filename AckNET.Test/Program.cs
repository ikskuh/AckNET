using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AckNET.EngineVars;

namespace AckNET.Test
{
	class Program
	{
		static void Main(string[] args)
		{
			Acknex.Open("-nx 200");
			Console.WriteLine("Using version {0}", EngineVars.Version);

			OnTab += (s,e ) => { Console.WriteLine("Pressed [TAB]"); };
			MouseMode = 3;

			// Initialize engine
			Acknex.Frame();

			Level.Load("");

			Acknex.Frame();

			EngineVars.SkyColor = Color.DeepSkyBlue;

			var ent = new Entity("cargo.mdl", new Vector(550.0, 0.0, 0.0));

			var snd = new Sound("beep.wav");

			OnSpace += (s,e) => { snd.Play(100, 0); };

			while (Acknex.Frame())
			{
				if (ent == EngineVars.MouseEnt)
				{
					ent.Pan += 1.5 * TimeStep;
				}

				Camera.Pan += (KeyCul - KeyCur) * TimeStep;

				if ((bool)KeyEsc)
				{
					break;
				}
			}

			Acknex.Close();
		}

		private static void EngineVars_OnMouseLeftEvent(object sender, EngineEventArgs e)
		{
			Console.WriteLine("Hey listen!");
		}
	}
}
