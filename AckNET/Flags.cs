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
	public enum EntityFlags2
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
	[Flags]
	public enum ParticleFlags
	{
		/// <summary>
		/// No flags are set.
		/// </summary>
		None = 0,

		/// <summary>
		/// Flag for generic use.
		/// </summary>
		Flag1 = (1 << 0),

		/// <summary>
		/// Flag for generic use.
		/// </summary>
		Flag2 = (1 << 1),

		/// <summary>
		/// Flag for generic use.
		/// </summary>
		Flag3 = (1 << 2),

		/// <summary>
		/// Flag for generic use.
		/// </summary>
		Flag4 = (1 << 3),

		/// <summary>
		/// Flag for generic use.
		/// </summary>
		Flag5 = (1 << 4),

		/// <summary>
		/// Flag for generic use.
		/// </summary>
		Flag6 = (1 << 5),

		/// <summary>
		/// Flag for generic use.
		/// </summary>
		Flag7 = (1 << 6),

		/// <summary>
		/// Flag for generic use.
		/// </summary>
		Flag8 = (1 << 7),

		/// <summary>
		/// If this flag is set, the particle will be translucent, so you can see through it,
		/// and it will be rendered on the transparent pass. Its transparency is determined by its alpha value. 
		/// </summary>
		Translucent = (1 << 10),

		/// <summary>
		/// If this flag is set for a map, model, or particle, black or transparent parts of the
		/// texture become completely invisible. 
		/// </summary>
		Overlay = (1 << 12),

		/// <summary>
		/// The particle is drawn without bilinear filtering and antialiasing. Thus the texture will look 'pixelated'.
		/// </summary>
		NoFilter = (1 << 16),

		/// <summary>
		/// In combination with alpha channel textures or transparency, blends the entity or particle over the
		/// background instead of mixing both. This way the colors add and the entity appears illuminated, like fire
		/// or sparks. In	combination	with UNLIT the entity receives an average environment light as by normal
		/// sunlight in the level.
		/// </summary>
		Bright = (1 << 21),

		/// <summary>
		/// Like BEAM, but stretches the particle along its velocity vector, instead of smearing it.
		/// This gives the effect a motion blur like appearance.
		/// </summary>
		Streak = (1 << 8),

		/// <summary>
		/// The particle is "smeared" along a line given by its velocity vector and starting at its position.
		/// Normally used for continuous rays or trails. In combination with the BRIGHT flag, lines of
		/// light can be created this way for laser, tracer bullet, vapor or light trail effects.
		/// </summary>
		Beam = (1 << 9),

		/// <summary>
		/// If this flag is set, the particle moves with its velocity vector, and accelerates with its gravity acceleration.
		/// </summary>
		Move = (1 << 11)
	}

	[Flags]
	public enum StringFlags
	{
		/// <summary>
		/// 
		/// </summary>
		None = 0,

		/// <summary>
		/// save the string at game_save()
		/// </summary>
		Save = (1 << 0),

		/// <summary>
		/// don't deallocate STRING->chars
		/// </summary>
		Constant = (1 << 2)
	}

	public enum SoundType
	{
		/// <summary>
		/// 
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// Sound is wave format.
		/// </summary>
		Wave = 2,

		/// <summary>
		/// Sound is ogg format.
		/// </summary>
		Ogg = 5
	}

	[Flags]
	public enum BitmapFlags
	{
		/// <summary>
		/// 
		/// </summary>
		None = 0,

		/// <summary>
		/// bitmap contains alpha channel
		/// </summary>
		Argb = (1 << 8),

		/// <summary>
		/// bitmap was modified
		/// </summary>
		Save = (1 << 9),

		/// <summary>
		/// bmap->pixels contains 3 mipmaps
		/// </summary>
		MipMaps = (1 << 10),
	}

	/// <summary>
	/// 
	/// </summary>
	[Flags]
	public enum HitFlags
	{
		None = 0,
		Block = (1 << 9),
		Entity = (1 << 10),
	}

	[Flags]
	public enum ViewFlags
	{
		None = 0
	}

	[Flags]
	public enum TextFlags
	{
		None = 0
	}

	[Flags]
	public enum PanelFlags
	{
		None = 0
	}

	[Flags]
	public enum MaterialFlags
	{
		None = 0
	}



	[Flags]
	public enum EventMask
	{
		None = 0
	}


	[Flags]
	public enum SendMask
	{
		None = 0
	}
}
