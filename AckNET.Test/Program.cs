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
			Acknex.Open("-nx 200 cargo.mdl");
			Console.WriteLine("Using version {0}", EngineVars.Version);

			OnTab = (x) => { Console.WriteLine("Pressed [TAB]"); return 0; };
			MouseMode = 3;
			while (Acknex.Frame())
			{
				if (MouseEnt != null)
				{
					MouseEnt.Position += new Vector(0, 0, (1 - 2 * (int)MouseLeft) * TimeStep);
				}
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
