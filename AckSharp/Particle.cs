using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AckSharp
{
	public partial class Particle : EngineObject
	{
		internal Particle(IntPtr handle)
			:base(false, handle)
		{

		}
	}
}
