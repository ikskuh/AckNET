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

			OnTab = (x) => { Console.WriteLine("Pressed [TAB]"); return 0; };
			MouseMode = 3;

			Level.Load("");

			Entity ent = new Entity("cargo.mdl", new Vector(550.0, 0.0, 0.0));

			while (Acknex.Frame())
			{
				if (ent == EngineVars.MouseEnt)
				{
					ent.Pan += 1.5 * TimeStep;
				}

				Camera.Pan += (KeyCul - KeyCur) * TimeStep;

				Console.WriteLine("{0} - {1} -> {2}", KeyCul, KeyCur, (KeyCul - KeyCur));

				if ((bool)MouseLeft)
				{
					Console.WriteLine("{0}:{1}:{2}", (int)SysHours, (int)SysMinutes, (int)SysSeconds);
				}

				if ((bool)KeyEsc)
				{
					break;
				}
			}

			Acknex.Close();
		}
	}
}
