namespace AckNET
{
	using System;
	using System.Runtime.InteropServices;

	partial class EngineObject
	{
		protected void CheckValid()
		{
			if (InternalPointer == IntPtr.Zero)
				throw new InvalidOperationException("Cannot use engine vars with uninitialized engine.");
		}

		protected ackvar GetVar(int offset)
		{
			CheckValid();
			return new ackvar(Marshal.ReadInt32(InternalPointer + offset));
		}
		protected void SetVar(int offset, ackvar @var)
		{
			CheckValid();
			Marshal.WriteInt32(InternalPointer + offset, @var.RawValue);
		}

		protected Vector GetVector(int offset)
		{
			CheckValid();
			return new Vector(
				GetVar(offset + 0),
				GetVar(offset + 4),
				GetVar(offset + 8));
		}

		protected void SetVector(int offset, Vector value)
		{
			CheckValid();
			SetVar(offset + 0, value.X);
			SetVar(offset + 4, value.Y);
			SetVar(offset + 8, value.Z);
		}
		protected Angle GetAngle(int offset)
		{
			CheckValid();
			return new Angle(
				GetVar(offset + 0),
				GetVar(offset + 4),
				GetVar(offset + 8));
		}

		protected void SetAngle(int offset, Angle value)
		{
			CheckValid();
			SetVar(offset + 0, value.Pan);
			SetVar(offset + 4, value.Tilt);
			SetVar(offset + 8, value.Roll);
		}

		protected Color GetColor(int offset)
		{
			CheckValid();
			// Note: rgb constructor, bgr layout!
			return new Color(
				GetVar(offset + 8),
				GetVar(offset + 4),
				GetVar(offset + 0));
		}

		protected void SetColor(int offset, Color value)
		{
			CheckValid();
			SetVar(offset + 0, value.Blue);
			SetVar(offset + 4, value.Green);
			SetVar(offset + 8, value.Red);
		}

		protected int GetInt(int offset)
		{
			CheckValid();
			return Marshal.ReadInt32(InternalPointer + offset);
		}
		protected void SetInt(int offset, int @var)
		{
			CheckValid();
			Marshal.WriteInt32(InternalPointer + offset, @var);
		}

		protected float GetFloat(int offset)
		{
			CheckValid();
			return BitConverter.ToSingle(BitConverter.GetBytes(Marshal.ReadInt32(InternalPointer + offset)), 0);
		}
		protected void SetFloat(int offset, float @var)
		{
			CheckValid();
			Marshal.WriteInt32(InternalPointer + offset, BitConverter.ToInt32(BitConverter.GetBytes(@var), 0));
		}

		protected Entity GetEntity(int offset)
		{
			CheckValid();
			var dref = Marshal.ReadIntPtr(InternalPointer + offset);
			if (dref != IntPtr.Zero)
				return new Entity(dref);
			else
				return null;
		}
		protected void SetEntity(int offset, Entity ent)
		{
			CheckValid();
			IntPtr ptr = ent != null ? ent.InternalPointer : IntPtr.Zero;
			Marshal.WriteIntPtr(InternalPointer + offset, ptr);
		}

		protected IntPtr GetPtr(int offset)
		{
			CheckValid();
			return Marshal.ReadIntPtr(InternalPointer + offset);
		}
		protected void SetPtr(int offset, IntPtr ptr)
		{
			CheckValid();
			Marshal.WriteIntPtr(InternalPointer + offset, ptr);
		}
		protected string GetString(int offset)
		{
			CheckValid();
			return Marshal.PtrToStringAnsi(GetPtr(offset));
		}

		protected void SetEvent(int offset, EngineEventDelegate @event)
		{
			IntPtr ptr = IntPtr.Zero;
			if (@event != null)
				ptr = Marshal.GetFunctionPointerForDelegate(@event);
			Marshal.WriteIntPtr(InternalPointer + offset, ptr);
		}
	}

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
		public ackvar Material { get { return GetVar(552); } set { SetVar(552, value); } }

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


		public Entity Shadow { get { return GetEntity(612); } set { SetEntity(612, value); } }

		public Entity Parent { get { return GetEntity(616); } set { SetEntity(616, value); } }

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
}
