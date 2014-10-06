using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AckNET
{
	[Flags]
	public enum EntityFlags
	{
		None = 0,
		Flag1 = (1 << 0),
		Flag2 = (1 << 1),
		Flag3 = (1 << 2),
		Flag4 = (1 << 3),
		Flag5 = (1 << 4),
		Flag6 = (1 << 5),
		Flag7 = (1 << 6),
		Flag8 = (1 << 7),

		Invisible = (1 << 8),
		Passable = (1 << 9),
		Translucent = (1 << 10),
		Overlay = (1 << 12),
		Spotlight = (1 << 13),
		ZNear = (1 << 14),
		NoFilter = (1 << 16),
		Unlit = (1 << 17),
		Shadow = (1 << 18),
		Light = (1 << 19),
		NoFog = (1 << 20),
		Bright = (1 << 21),
		Decal = (1 << 22),
		Metal = (1 << 22),
		Cast = (1 << 23),
		Polygon = (1 << 26),
	}

	[Flags]
	public enum EntitiyFlags2
	{
		None = 0,
		Untouchable = (1 << 0),
		Show = (1 << 14),
		Sky = (1 << 17),
		Dome = (1 << 18),
		Scene = (1 << 19),
		Cube = (1 << 20),
		Cylinder = (1 << 21)
	}

	[Flags]
	public enum EntityEFlags
	{
		None = 0,
		Fat = (1 << 0),
		Narrow = (1 << 1),
		PassTransparent = (1 << 7),
		PassBoth = (1 << 8),
		Lod0 = (1 << 16),
		Lod1 = (1 << 17),
		Clip0 = (1 << 18),
		Clip1 = (1 << 19),
		Clipped = (1 << 21),
		Animate = (1 << 24),
		Local = (1 << 25)
	}
}
