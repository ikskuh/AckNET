namespace AckNET
{
	using System;
	using System.Runtime.InteropServices;

	partial class Entity
	{
		public string Type { get { return GetString(12); } }

		public Vector Position { get { return GetVector(16); } set { SetVector(16, value); } }

		public ackvar X { get { return GetVar(16); } set { SetVar(16, value); } }
		public ackvar Y { get { return GetVar(20); } set { SetVar(20, value); } }
		public ackvar Z { get { return GetVar(24); } set { SetVar(24, value); } }


		public Angle Rotation { get { return GetAngle(28); } set { SetAngle(28, value); } }

		public ackvar Pan { get { return GetVar(28); } set { SetVar(28, value); } }
		public ackvar Tilt { get { return GetVar(32); } set { SetVar(32, value); } }
		public ackvar Roll { get { return GetVar(36); } set { SetVar(36, value); } }


		public Vector Scale { get { return GetVector(40); } set { SetVector(40, value); } }

		public ackvar ScaleX { get { return GetVar(40); } set { SetVar(40, value); } }
		public ackvar ScaleY { get { return GetVar(44); } set { SetVar(44, value); } }
		public ackvar ScaleZ { get { return GetVar(48); } set { SetVar(48, value); } }

		public int Flags { get { return GetInt(52); } set { SetInt(52, value); } }

		public ackvar Frame { get { return GetVar(56); } set { SetVar(56, value); } }

		public ackvar NextFrame { get { return GetVar(60); } set { SetVar(60, value); } }

		public ackvar Skin { get { return GetVar(64); } set { SetVar(64, value); } }

		public ackvar Ambient { get { return GetVar(68); } set { SetVar(68, value); } }

		public ackvar Albedo { get { return GetVar(72); } set { SetVar(72, value); } }

		public ackvar Alpha { get { return GetVar(76); } set { SetVar(76, value); } }

		public ackvar Lightrange { get { return GetVar(80); } set { SetVar(80, value); } }


		public Color Color { get { return GetColor(84); } set { SetColor(84, value); } }

		public ackvar Blue { get { return GetVar(84); } set { SetVar(84, value); } }
		public ackvar Green { get { return GetVar(88); } set { SetVar(88, value); } }

		public ackvar Red { get { return GetVar(92); } set { SetVar(92, value); } }


		public int EMask { get { return GetInt(96); } set { SetInt(96, value); } }


		public int EFlags { get { return GetInt(100); } set { SetInt(100, value); } }


		public Vector Minimum { get { return GetVector(104); } set { SetVector(104, value); } }

		public ackvar MinX { get { return GetVar(104); } set { SetVar(104, value); } }

		public ackvar MinY { get { return GetVar(108); } set { SetVar(108, value); } }

		public ackvar MinZ { get { return GetVar(112); } set { SetVar(112, value); } }


		public Vector Maximum { get { return GetVector(116); } set { SetVector(116, value); } }
		public ackvar MaxX { get { return GetVar(116); } set { SetVar(116, value); } }

		public ackvar MaxY { get { return GetVar(120); } set { SetVar(120, value); } }

		public ackvar MaxZ { get { return GetVar(124); } set { SetVar(124, value); } }

		public ackvar TriggerRange { get { return GetVar(128); } set { SetVar(128, value); } }

		public ackvar Push { get { return GetVar(132); } set { SetVar(132, value); } }

		public ackvar FloorDist { get { return GetVar(136); } set { SetVar(136, value); } }

		public int SMask { get { return GetInt(140); } set { SetInt(140, value); } }

		public ackvar ClientID { get { return GetVar(144); } set { SetVar(144, value); } }


		public ackvar this[int skill] { get { return GetVar(148 + -8 * skill); } set { SetVar(148 + -8 * skill, value); } }


		public ackvar Pose { get { return GetVar(548); } set { SetVar(548, value); } }

		// TODO: Change to Material
		public Material Material { get { return GetMaterial(552); } set { SetObject(552, value); } }

		public ackvar U { get { return GetVar(556); } set { SetVar(556, value); } }

		public ackvar V { get { return GetVar(560); } set { SetVar(560, value); } }

		public ackvar Group { get { return GetVar(564); } set { SetVar(564, value); } }

		public int Flags2 { get { return GetInt(568); } set { SetInt(568, value); } }

		public string Attachname { get { return GetString(572); } }


		EngineEventDelegate @event;
		public EngineEventDelegate Event { get { return @event; } set { @event = value; SetEvent(576, @event); } }

		EngineEventDelegate local;
		public EngineEventDelegate Local { get { return local; } set { local = value; SetEvent(580, local); } }

		public ackvar Layer { get { return GetVar(584); } set { SetVar(584, value); } }


		public int VMask { get { return GetInt(588); } set { SetInt(588, value); } }


		public string String1 { get { return GetString(592); } }

		public string String2 { get { return GetString(596); } }

		public float Radius { get { return GetFloat(600); } set { SetFloat(600, value); } }

		public int PathIndex { get { return GetInt(604); } set { SetInt(604, value); } }


		public IntPtr Model { get { return GetPtr(608); } set { SetPtr(608, value); } }


		public Entity Shadow { get { return GetEntity(612); } set { SetObject(612, value); } }

		public Entity Parent { get { return GetEntity(616); } set { SetObject(616, value); } }

		// TODO: Change to Bmap
		public ackvar Lightmap { get { return GetVar(620); } set { SetVar(620, value); } }

		public IntPtr Body { get { return GetPtr(624); } set { SetPtr(624, value); } }

		public ackvar Clipfactor { get { return GetVar(628); } set { SetVar(628, value); } }

		/*
		typedef struct ENTITY {
			C_LINK link; 
			char *type; // -> 24
			var x,y,z; // -> 28
			var pan,tilt,roll; // -> 40
			var scale_x,scale_y,scale_z; // -> 52
			long flags; // -> 64
			var frame; // -> 68
			var next_frame; // -> 72
			var skin; // -> 76
			var ambient; // -> 80
			var albedo; // -> 84
			var alpha; // -> 88
			var lightrange; // -> 92
			var blue,green,red; // -> 96
			long emask; // -> 108
			long eflags; // -> 112
			var min_x,min_y,min_z; // -> 116
			var max_x,max_y,max_z; // -> 128
			var trigger_range; // -> 140
			var push; // -> 144
			var floor_dist; // -> 148
			long smask; // -> 152
			var client_id; // -> 156
			var skill[100]; // -> 160
			var pose; // -> 560
			MATERIAL* material; // -> 564
			var u,v; // -> 568
			var group; // -> 576
			long flags2; // -> 580
			char *attachname; // -> 584
			EVENT event; // -> 588
			EVENT local; // -> 592
			var layer; // -> 596
			long vmask; // -> 600
			char *string1,*string2; // -> 604
			float fRadius; // -> 612
			long path_index; // -> 616
			void* model; // -> 620
			struct ENTITY* shadow; // -> 624
			struct ENTITY* parent; // -> 628
			BMAP* lightmap; // -> 632
			void* body; // -> 636
			var clipfactor; // -> 640
		} ENTITY;
		*/
	}

	partial class Material
	{
		public Color Ambient { get { return GetColor(12); } set { SetColor(12, value); } }
		public ackvar AmbientBlue { get { return GetVar(12); } set { SetVar(12, value); } }
		public ackvar AmbientGreen { get { return GetVar(16); } set { SetVar(16, value); } }
		public ackvar AmbientRed { get { return GetVar(20); } set { SetVar(20, value); } }

		public Color Diffuse { get { return GetColor(24); } set { SetColor(24, value); } }
		public ackvar DiffuseBlue { get { return GetVar(24); } set { SetVar(24, value); } }
		public ackvar DiffuseGreen { get { return GetVar(28); } set { SetVar(28, value); } }
		public ackvar DiffuseRed { get { return GetVar(32); } set { SetVar(32, value); } }

		public Color Specular { get { return GetColor(36); } set { SetColor(36, value); } }
		public ackvar SpecularBlue { get { return GetVar(36); } set { SetVar(36, value); } }
		public ackvar SpecularGreen { get { return GetVar(40); } set { SetVar(40, value); } }
		public ackvar SpecularRed { get { return GetVar(44); } set { SetVar(44, value); } }

		public Color Emissive { get { return GetColor(48); } set { SetColor(48, value); } }
		public ackvar EmissiveBlue { get { return GetVar(48); } set { SetVar(48, value); } }
		public ackvar EmissiveGreen { get { return GetVar(52); } set { SetVar(52, value); } }
		public ackvar EmissiveRed { get { return GetVar(56); } set { SetVar(56, value); } }

		public Color Map { get { return GetColor(60); } set { SetColor(60, value); } }
		public ackvar MapBlue { get { return GetVar(60); } set { SetVar(60, value); } }
		public ackvar MapGreen { get { return GetVar(64); } set { SetVar(64, value); } }
		public ackvar MapRed { get { return GetVar(68); } set { SetVar(68, value); } }
		public ackvar Alpha { get { return GetVar(72); } set { SetVar(72, value); } }
		public ackvar Power { get { return GetVar(76); } set { SetVar(76, value); } }
		public ackvar Albedo { get { return GetVar(80); } set { SetVar(80, value); } }
		public ackvar Scale1 { get { return GetVar(84); } set { SetVar(84, value); } }
		public ackvar Scale2 { get { return GetVar(88); } set { SetVar(88, value); } }
		public ackvar Cycle { get { return GetVar(92); } set { SetVar(92, value); } }
		public ackvar this[int skill] { get { return GetVar(96); } set { SetVar(96 + 4 * skill, value); } }

		// TODO: Implement matrix
		//public Matrix4x4 Matrix { get { return GetMatrix(100); } set { SetMatrix(100, value); } }

		public int Flags { get { return GetInt(104); } set { SetInt(104, value); } }

		// TODO: Implement "set" string
		public string effect { get { return GetString(108); } /* set { SetVar(108, value); } */ }
		public ackvar Lod { get { return GetVar(112); } set { SetVar(112, value); } }

		// TODO: Implement get/set materials
		//public ackBMAP* skin1 { get { return GetVar(116); } set { SetVar(116, value); } }
		//public ackBMAP* skin2 { get { return GetVar(120); } set { SetVar(120, value); } }
		//public ackBMAP* skin3 { get { return GetVar(124); } set { SetVar(124, value); } }
		//public ackBMAP* skin4 { get { return GetVar(128); } set { SetVar(128, value); } }

		EngineEventDelegate @event;
		public EngineEventDelegate Event { get { return @event; } set { @event = value; SetEvent(132, @event); } }
		public IntPtr D3deffect { get { return GetPtr(136); } set { SetPtr(136, value); } }
		public IntPtr D3dmaterial { get { return GetPtr(140); } set { SetPtr(140, value); } }

		// TODO: Implement "set" string
		public string Technique { get { return GetString(144); } /* set { SetVar(144, value); } */ }
		public ackvar Maxbones { get { return GetVar(148); } set { SetVar(148, value); } }
	}

	partial class View
	{
		public int Type { get { return GetInt(12); } set { SetInt(12, value); } }
		public ackvar Layer { get { return GetVar(16); } set { SetVar(16, value); } }
		public ackvar PosX { get { return GetVar(20); } set { SetVar(20, value); } }
		public ackvar PosY { get { return GetVar(24); } set { SetVar(24, value); } }
		public int Flags { get { return GetInt(28); } set { SetInt(28, value); } }
		public ackvar SizeX { get { return GetVar(32); } set { SetVar(32, value); } }
		public ackvar SizeY { get { return GetVar(36); } set { SetVar(36, value); } }
		public ackvar X { get { return GetVar(40); } set { SetVar(40, value); } }
		public ackvar Y { get { return GetVar(44); } set { SetVar(44, value); } }
		public ackvar Z { get { return GetVar(48); } set { SetVar(48, value); } }
		public ackvar Pan { get { return GetVar(52); } set { SetVar(52, value); } }
		public ackvar Tilt { get { return GetVar(56); } set { SetVar(56, value); } }
		public ackvar Roll { get { return GetVar(60); } set { SetVar(60, value); } }
		public ackvar OffsetX { get { return GetVar(64); } set { SetVar(64, value); } }
		public ackvar OffsetY { get { return GetVar(68); } set { SetVar(68, value); } }
		public ackvar Arc { get { return GetVar(72); } set { SetVar(72, value); } }
		public ackvar Aspect { get { return GetVar(76); } set { SetVar(76, value); } }
		public ackvar Ambient { get { return GetVar(80); } set { SetVar(80, value); } }
		public ackvar Bg { get { return GetVar(84); } set { SetVar(84, value); } }
		public ackvar Alpha { get { return GetVar(88); } set { SetVar(88, value); } }
		public ackvar PortalX { get { return GetVar(92); } set { SetVar(92, value); } }
		public ackvar PortalY { get { return GetVar(96); } set { SetVar(96, value); } }
		public ackvar PortalZ { get { return GetVar(100); } set { SetVar(100, value); } }
		public ackvar PnormalX { get { return GetVar(104); } set { SetVar(104, value); } }
		public ackvar PnormalY { get { return GetVar(108); } set { SetVar(108, value); } }
		public ackvar PnormalZ { get { return GetVar(112); } set { SetVar(112, value); } }
		public ackvar FogStart { get { return GetVar(116); } set { SetVar(116, value); } }
		public ackvar FogEnd { get { return GetVar(120); } set { SetVar(120, value); } }
		public ackvar Depth { get { return GetVar(124); } set { SetVar(124, value); } }
		public Entity Genius { get { return GetEntity(128); } set { SetObject(128, value); } }
		public View Portal { get { return GetView(132); } set { SetObject(132, value); } }
		//public BMAP* Bmap { get { return GetVar(136); } set { SetObject(136, value); } }
		public ackvar ClipNear { get { return GetVar(140); } set { SetVar(140, value); } }
		public ackvar ClipFar { get { return GetVar(144); } set { SetVar(144, value); } }
		public Material Material { get { return GetMaterial(148); } set { SetObject(148, value); } }
		public View Stage { get { return GetView(152); } set { SetObject(152, value); } }
		public ackvar Monitor { get { return GetVar(156); } set { SetVar(156, value); } }
		public ackvar SkillX { get { return GetVar(160); } set { SetVar(160, value); } }
		public ackvar SkillY { get { return GetVar(164); } set { SetVar(164, value); } }
		public ackvar Lod { get { return GetVar(168); } set { SetVar(168, value); } }
		public ackvar Left { get { return GetVar(172); } set { SetVar(172, value); } }
		public ackvar Right { get { return GetVar(176); } set { SetVar(176, value); } }
		public ackvar Bottom { get { return GetVar(180); } set { SetVar(180, value); } }
		public ackvar Top { get { return GetVar(184); } set { SetVar(184, value); } }
		//public BMAP* Target1 { get { return GetVar(188); } set { SetVar(188, value); } }
		//public BMAP* Target2 { get { return GetVar(192); } set { SetVar(192, value); } }
		//public BMAP* Target3 { get { return GetVar(196); } set { SetVar(196, value); } }
	}
}
