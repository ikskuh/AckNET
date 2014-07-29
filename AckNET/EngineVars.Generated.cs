namespace AckNET
{
	using System;
	partial class EngineVars
	{


		// # 1 "avars.h"
// # 1 "avars.h"

		// # 1 "<command-line>"
// # 1 "<command-line>"

		// # 1 "avars.h"
// # 1 "avars.h"

		// ENGINE_VAR version;
		public static ackvar Version { get { return GetVar(0); } set { SetVar(0, value); } }

		// ENGINE_VAR edition;
		public static ackvar Edition { get { return GetVar(4); } set { SetVar(4, value); } }

		// ENGINE_VAR compatibility;
		public static ackvar Compatibility { get { return GetVar(8); } set { SetVar(8, value); } }

		// ENGINE_VAR logo;
		public static ackvar Logo { get { return GetVar(12); } set { SetVar(12, value); } }

		// ENGINE_VAR nexus;
		public static ackvar Nexus { get { return GetVar(16); } set { SetVar(16, value); } }

		// ENGINE_VAR event_type;
		public static ackvar EventType { get { return GetVar(20); } set { SetVar(20, value); } }

		// ENGINE_VAR warn_level;
		public static ackvar WarnLevel { get { return GetVar(24); } set { SetVar(24, value); } }

		// ENGINE_VAR max_loops;
		public static ackvar MaxLoops { get { return GetVar(28); } set { SetVar(28, value); } }

		// ENGINE_VAR freeze_mode;
		public static ackvar FreezeMode { get { return GetVar(32); } set { SetVar(32, value); } }

		// ENGINE_VAR debug_mode;
		public static ackvar DebugMode { get { return GetVar(36); } set { SetVar(36, value); } }

		// ENGINE_VAR debug_external;
		public static ackvar DebugExternal { get { return GetVar(40); } set { SetVar(40, value); } }

		// ENGINE_VAR mtl_mode;
		public static ackvar MtlMode { get { return GetVar(44); } set { SetVar(44, value); } }

		// ENGINE_VAR last_error;
		public static ackvar LastError { get { return GetVar(48); } set { SetVar(48, value); } }

		// ENGINE_VAR proc_mode;
		public static ackvar ProcMode { get { return GetVar(52); } set { SetVar(52, value); } }

		// ENGINE_VAR run_mode;
		public static ackvar RunMode { get { return GetVar(56); } set { SetVar(56, value); } }

		// ENGINE_VAR patch;
		public static ackvar Patch { get { return GetVar(60); } set { SetVar(60, value); } }

		// ENGINE_VAR result;
		public static ackvar Result { get { return GetVar(64); } set { SetVar(64, value); } }

		// ENGINE_VAR max_nexus;
		public static ackvar MaxNexus { get { return GetVar(68); } set { SetVar(68, value); } }

		// ENGINE_VAR diag_mode;
		public static ackvar DiagMode { get { return GetVar(72); } set { SetVar(72, value); } }

		// ENGINE_VAR record_mode;
		public static ackvar RecordMode { get { return GetVar(76); } set { SetVar(76, value); } }

		// ENGINE_VAR time_step;
		public static ackvar TimeStep { get { return GetVar(80); } set { SetVar(80, value); } }

		// ENGINE_VAR time_factor;
		public static ackvar TimeFactor { get { return GetVar(84); } set { SetVar(84, value); } }

		// ENGINE_VAR time_smooth;
		public static ackvar TimeSmooth { get { return GetVar(88); } set { SetVar(88, value); } }

		// ENGINE_VAR time_frame;
		public static ackvar TimeFrame { get { return GetVar(92); } set { SetVar(92, value); } }

		// ENGINE_VAR total_ticks;
		public static ackvar TotalTicks { get { return GetVar(96); } set { SetVar(96, value); } }

		// ENGINE_VAR total_secs;
		public static ackvar TotalSecs { get { return GetVar(100); } set { SetVar(100, value); } }

		// ENGINE_VAR total_frames;
		public static ackvar TotalFrames { get { return GetVar(104); } set { SetVar(104, value); } }

		// ENGINE_VAR fps_max;
		public static ackvar FpsMax { get { return GetVar(108); } set { SetVar(108, value); } }

		// ENGINE_VAR fps_min;
		public static ackvar FpsMin { get { return GetVar(112); } set { SetVar(112, value); } }

		// ENGINE_VAR fps_lock;
		public static ackvar FpsLock { get { return GetVar(116); } set { SetVar(116, value); } }

		// ENGINE_VAR time_actions;
		public static ackvar TimeActions { get { return GetVar(132); } set { SetVar(132, value); } }

		// ENGINE_VAR time_render;
		public static ackvar TimeRender { get { return GetVar(136); } set { SetVar(136, value); } }

		// ENGINE_VAR time_level;
		public static ackvar TimeLevel { get { return GetVar(140); } set { SetVar(140, value); } }

		// ENGINE_VAR time_entities;
		public static ackvar TimeEntities { get { return GetVar(144); } set { SetVar(144, value); } }

		// ENGINE_VAR time_effects;
		public static ackvar TimeEffects { get { return GetVar(148); } set { SetVar(148, value); } }

		// ENGINE_VAR time_pfuncs;
		public static ackvar TimePfuncs { get { return GetVar(152); } set { SetVar(152, value); } }

		// ENGINE_VAR time_portals;
		public static ackvar TimePortals { get { return GetVar(156); } set { SetVar(156, value); } }

		// ENGINE_VAR time_sky;
		public static ackvar TimeSky { get { return GetVar(160); } set { SetVar(160, value); } }

		// ENGINE_VAR time_client;
		public static ackvar TimeClient { get { return GetVar(164); } set { SetVar(164, value); } }

		// ENGINE_VAR time_server;
		public static ackvar TimeServer { get { return GetVar(168); } set { SetVar(168, value); } }

		// ENGINE_VAR time_panels;
		public static ackvar TimePanels { get { return GetVar(172); } set { SetVar(172, value); } }

		// ENGINE_VAR time_update;
		public static ackvar TimeUpdate { get { return GetVar(176); } set { SetVar(176, value); } }

		// ENGINE_VAR time_physics;
		public static ackvar TimePhysics { get { return GetVar(180); } set { SetVar(180, value); } }

		// ENGINE_VAR time_total;
		public static ackvar TimeTotal { get { return GetVar(184); } set { SetVar(184, value); } }

		// ENGINE_VAR time_idle;
		public static ackvar TimeIdle { get { return GetVar(188); } set { SetVar(188, value); } }

		// ENGINE_VAR time_draw;
		public static ackvar TimeDraw { get { return GetVar(192); } set { SetVar(192, value); } }

		// ENGINE_VAR time_scope;
		public static ackvar TimeScope { get { return GetVar(196); } set { SetVar(196, value); } }

		// ENGINE_VAR sys_seconds;
		public static ackvar SysSeconds { get { return GetVar(200); } set { SetVar(200, value); } }

		// ENGINE_VAR sys_minutes;
		public static ackvar SysMinutes { get { return GetVar(204); } set { SetVar(204, value); } }

		// ENGINE_VAR sys_hours;
		public static ackvar SysHours { get { return GetVar(208); } set { SetVar(208, value); } }

		// ENGINE_VAR sys_day;
		public static ackvar SysDay { get { return GetVar(212); } set { SetVar(212, value); } }

		// ENGINE_VAR sys_month;
		public static ackvar SysMonth { get { return GetVar(216); } set { SetVar(216, value); } }

		// ENGINE_VAR sys_year;
		public static ackvar SysYear { get { return GetVar(220); } set { SetVar(220, value); } }

		// ENGINE_VAR sys_dow;
		public static ackvar SysDow { get { return GetVar(224); } set { SetVar(224, value); } }

		// ENGINE_VAR sys_doy;
		public static ackvar SysDoy { get { return GetVar(228); } set { SetVar(228, value); } }

		// ENGINE_VAR sys_memory;
		public static ackvar SysMemory { get { return GetVar(232); } set { SetVar(232, value); } }

		// ENGINE_VAR sys_winversion;
		public static ackvar SysWinversion { get { return GetVar(236); } set { SetVar(236, value); } }

		// ENGINE_VAR enable_joystick;
		public static ackvar EnableJoystick { get { return GetVar(256); } set { SetVar(256, value); } }

		// ENGINE_VAR num_joysticks;
		public static ackvar NumJoysticks { get { return GetVar(260); } set { SetVar(260, value); } }

		// ENGINE_VAR joy_sense;
		public static ackvar JoySense { get { return GetVar(264); } set { SetVar(264, value); } }

		// ENGINE_VECTOR joy_force;
		public static Vector JoyForce { get { return GetVector(268); } set { SetVector(268, value); } }

		// ENGINE_VECTOR joy_raw;
		public static Vector JoyRaw { get { return GetVector(272); } set { SetVector(272, value); } }

		// ENGINE_VECTOR joy_rot;
		public static Vector JoyRot { get { return GetVector(276); } set { SetVector(276, value); } }

		// ENGINE_VAR joy_hat;
		public static ackvar JoyHat { get { return GetVar(280); } set { SetVar(280, value); } }

		// ENGINE_VECTOR joy2_raw;
		public static Vector Joy2Raw { get { return GetVector(284); } set { SetVector(284, value); } }

		// ENGINE_VECTOR joy2_rot;
		public static Vector Joy2Rot { get { return GetVector(288); } set { SetVector(288, value); } }

		// ENGINE_VAR joy2_hat;
		public static ackvar Joy2Hat { get { return GetVar(292); } set { SetVar(292, value); } }

		// ENGINE_VAR joy_buttons;
		public static ackvar JoyButtons { get { return GetVar(296); } set { SetVar(296, value); } }

		// ENGINE_VAR joy2_buttons;
		public static ackvar Joy2Buttons { get { return GetVar(300); } set { SetVar(300, value); } }

		// ENGINE_VAR enable_mouse;
		public static ackvar EnableMouse { get { return GetVar(308); } set { SetVar(308, value); } }

		// ENGINE_VAR mouse_mode;
		public static ackvar MouseMode { get { return GetVar(312); } set { SetVar(312, value); } }

		// ENGINE_VAR mouse_sense;
		public static ackvar MouseSense { get { return GetVar(316); } set { SetVar(316, value); } }

		// ENGINE_VECTOR mouse_force;
		public static Vector MouseForce { get { return GetVector(320); } set { SetVector(320, value); } }

		// ENGINE_VECTOR mouse_pos;
		public static Vector MousePos { get { return GetVector(324); } set { SetVector(324, value); } }

		// ENGINE_VECTOR mouse_spot;
		public static Vector MouseSpot { get { return GetVector(328); } set { SetVector(328, value); } }

		// ENGINE_VAR mouse_pointer;
		public static ackvar MousePointer { get { return GetVar(332); } set { SetVar(332, value); } }

		// ENGINE_VAR mouse_range;
		public static ackvar MouseRange { get { return GetVar(336); } set { SetVar(336, value); } }

		// ENGINE_VAR mouse_time;
		public static ackvar MouseTime { get { return GetVar(340); } set { SetVar(340, value); } }

		// ENGINE_VAR mouse_moving;
		public static ackvar MouseMoving { get { return GetVar(344); } set { SetVar(344, value); } }

		// ENGINE_VAR mouse_calm;
		public static ackvar MouseCalm { get { return GetVar(348); } set { SetVar(348, value); } }

		// ENGINE_VAR mouse_sync;
		public static ackvar MouseSync { get { return GetVar(352); } set { SetVar(352, value); } }

		// ENGINE_VAR mouse_valid;
		public static ackvar MouseValid { get { return GetVar(356); } set { SetVar(356, value); } }

		// ENGINE_VAR touch_state;
		public static ackvar TouchState { get { return GetVar(360); } set { SetVar(360, value); } }

		// ENGINE_VECTOR mickey;
		public static Vector Mickey { get { return GetVector(364); } set { SetVector(364, value); } }

		// ENGINE_VECTOR mouse_cursor;
		public static Vector MouseCursor { get { return GetVector(368); } set { SetVector(368, value); } }

		// ENGINE_VECTOR mouse_pos3d;
		public static Vector MousePos3d { get { return GetVector(372); } set { SetVector(372, value); } }

		// ENGINE_VECTOR mouse_dir3d;
		public static Vector MouseDir3d { get { return GetVector(376); } set { SetVector(376, value); } }

		// ENGINE_VAR enable_key;
		public static ackvar EnableKey { get { return GetVar(392); } set { SetVar(392, value); } }

		// ENGINE_VAR key_sense;
		public static ackvar KeySense { get { return GetVar(396); } set { SetVar(396, value); } }

		// ENGINE_VECTOR key_force;
		public static Vector KeyForce { get { return GetVector(400); } set { SetVector(400, value); } }

		// ENGINE_VAR shift_sense;
		public static ackvar ShiftSense { get { return GetVar(404); } set { SetVar(404, value); } }

		// ENGINE_VAR key_shift;
		public static ackvar KeyShift { get { return GetVar(408); } set { SetVar(408, value); } }

		// ENGINE_VAR key_any;
		public static ackvar KeyAny { get { return GetVar(412); } set { SetVar(412, value); } }

		// ENGINE_VAR key_lastpressed;
		public static ackvar KeyLastpressed { get { return GetVar(416); } set { SetVar(416, value); } }

		// ENGINE_VAR inkey_active;
		public static ackvar InkeyActive { get { return GetVar(420); } set { SetVar(420, value); } }

		// ENGINE_VAR text_outline;
		public static ackvar TextOutline { get { return GetVar(424); } set { SetVar(424, value); } }

		// ENGINE_VAR decal_clip;
		public static ackvar DecalClip { get { return GetVar(428); } set { SetVar(428, value); } }

		// ENGINE_VAR video_aspect;
		public static ackvar VideoAspect { get { return GetVar(432); } set { SetVar(432, value); } }

		// ENGINE_VAR video_mode;
		public static ackvar VideoMode { get { return GetVar(436); } set { SetVar(436, value); } }

		// ENGINE_VAR video_depth;
		public static ackvar VideoDepth { get { return GetVar(440); } set { SetVar(440, value); } }

		// ENGINE_VAR video_screen;
		public static ackvar VideoScreen { get { return GetVar(444); } set { SetVar(444, value); } }

		// ENGINE_VECTOR screen_size;
		public static Vector ScreenSize { get { return GetVector(448); } set { SetVector(448, value); } }

		// ENGINE_COLOR screen_color;
		public static Color ScreenColor { get { return (Color)GetVector(452); } set { SetVector(452, (Vector)value); } }

		// ENGINE_VAR window_focus;
		public static ackvar WindowFocus { get { return GetVar(456); } set { SetVar(456, value); } }

		// ENGINE_VAR video_gamma;
		public static ackvar VideoGamma { get { return GetVar(460); } set { SetVar(460, value); } }

		// ENGINE_VECTOR window_pos;
		public static Vector WindowPos { get { return GetVector(464); } set { SetVector(464, value); } }

		// ENGINE_VAR d3d_antialias;
		public static ackvar D3dAntialias { get { return GetVar(468); } set { SetVar(468, value); } }

		// ENGINE_VAR mip_levels;
		public static ackvar MipLevels { get { return GetVar(472); } set { SetVar(472, value); } }

		// ENGINE_COLOR ambient_color;
		public static Color AmbientColor { get { return (Color)GetVector(476); } set { SetVector(476, (Vector)value); } }

		// ENGINE_VAR d3d_caps;
		public static ackvar D3dCaps { get { return GetVar(480); } set { SetVar(480, value); } }

		// ENGINE_VAR d3d_optimize;
		public static ackvar D3dOptimize { get { return GetVar(484); } set { SetVar(484, value); } }

		// ENGINE_VAR d3d_mode;
		public static ackvar D3dMode { get { return GetVar(488); } set { SetVar(488, value); } }

		// ENGINE_VAR d3d_nobsp;
		public static ackvar D3dNobsp { get { return GetVar(492); } set { SetVar(492, value); } }

		// ENGINE_VAR d3d_noents;
		public static ackvar D3dNoents { get { return GetVar(496); } set { SetVar(496, value); } }

		// ENGINE_VAR d3d_novis;
		public static ackvar D3dNovis { get { return GetVar(500); } set { SetVar(500, value); } }

		// ENGINE_VAR d3d_notex;
		public static ackvar D3dNotex { get { return GetVar(504); } set { SetVar(504, value); } }

		// ENGINE_VAR d3d_flags;
		public static ackvar D3dFlags { get { return GetVar(508); } set { SetVar(508, value); } }

		// ENGINE_VAR d3d_lightres;
		public static ackvar D3dLightres { get { return GetVar(512); } set { SetVar(512, value); } }

		// ENGINE_VAR d3d_monochrome;
		public static ackvar D3dMonochrome { get { return GetVar(516); } set { SetVar(516, value); } }

		// ENGINE_VAR d3d_lines;
		public static ackvar D3dLines { get { return GetVar(520); } set { SetVar(520, value); } }

		// ENGINE_VAR d3d_anisotropy;
		public static ackvar D3dAnisotropy { get { return GetVar(524); } set { SetVar(524, value); } }

		// ENGINE_VAR d3d_instancing;
		public static ackvar D3dInstancing { get { return GetVar(528); } set { SetVar(528, value); } }

		// ENGINE_VAR d3d_lockable;
		public static ackvar D3dLockable { get { return GetVar(532); } set { SetVar(532, value); } }

		// ENGINE_VAR effect_lod;
		public static ackvar EffectLod { get { return GetVar(536); } set { SetVar(536, value); } }

		// ENGINE_VAR d3d_autotransparency;
		public static ackvar D3dAutotransparency { get { return GetVar(540); } set { SetVar(540, value); } }

		// ENGINE_VAR d3d_automaterial;
		public static ackvar D3dAutomaterial { get { return GetVar(544); } set { SetVar(544, value); } }

		// ENGINE_VAR d3d_shaderversion;
		public static ackvar D3dShaderversion { get { return GetVar(548); } set { SetVar(548, value); } }

		// ENGINE_VAR shadow_offset;
		public static ackvar ShadowOffset { get { return GetVar(552); } set { SetVar(552, value); } }

		// ENGINE_VAR shadow_threshold;
		public static ackvar ShadowThreshold { get { return GetVar(556); } set { SetVar(556, value); } }

		// ENGINE_VAR shadow_range;
		public static ackvar ShadowRange { get { return GetVar(560); } set { SetVar(560, value); } }

		// ENGINE_VAR shadow_stencil;
		public static ackvar ShadowStencil { get { return GetVar(564); } set { SetVar(564, value); } }

		// ENGINE_VAR d3d_shadowdepth;
		public static ackvar D3dShadowdepth { get { return GetVar(568); } set { SetVar(568, value); } }

		// ENGINE_VAR d3d_alphadepth;
		public static ackvar D3dAlphadepth { get { return GetVar(572); } set { SetVar(572, value); } }

		// ENGINE_VAR shadow_lod;
		public static ackvar ShadowLod { get { return GetVar(576); } set { SetVar(576, value); } }

		// ENGINE_VAR d3d_texsmaps;
		public static ackvar D3dTexsmaps { get { return GetVar(580); } set { SetVar(580, value); } }

		// ENGINE_VAR d3d_texbmaps;
		public static ackvar D3dTexbmaps { get { return GetVar(584); } set { SetVar(584, value); } }

		// ENGINE_VAR d3d_texskins;
		public static ackvar D3dTexskins { get { return GetVar(588); } set { SetVar(588, value); } }

		// ENGINE_VAR d3d_texsurfs;
		public static ackvar D3dTexsurfs { get { return GetVar(592); } set { SetVar(592, value); } }

		// ENGINE_VAR d3d_textotal;
		public static ackvar D3dTextotal { get { return GetVar(596); } set { SetVar(596, value); } }

		// ENGINE_VAR d3d_texmemory;
		public static ackvar D3dTexmemory { get { return GetVar(600); } set { SetVar(600, value); } }

		// ENGINE_VAR d3d_alpharef;
		public static ackvar D3dAlpharef { get { return GetVar(604); } set { SetVar(604, value); } }

		// ENGINE_VAR d3d_texfree;
		public static ackvar D3dTexfree { get { return GetVar(608); } set { SetVar(608, value); } }

		// ENGINE_VAR d3d_texdepth;
		public static ackvar D3dTexdepth { get { return GetVar(612); } set { SetVar(612, value); } }

		// ENGINE_VAR d3d_texmax;
		public static ackvar D3dTexmax { get { return GetVar(616); } set { SetVar(616, value); } }

		// ENGINE_VAR d3d_texlimit;
		public static ackvar D3dTexlimit { get { return GetVar(620); } set { SetVar(620, value); } }

		// ENGINE_VAR d3d_entsort;
		public static ackvar D3dEntsort { get { return GetVar(624); } set { SetVar(624, value); } }

		// ENGINE_VAR d3d_near_sprites;
		public static ackvar D3dNearSprites { get { return GetVar(628); } set { SetVar(628, value); } }

		// ENGINE_VAR d3d_mipmapping;
		public static ackvar D3dMipmapping { get { return GetVar(632); } set { SetVar(632, value); } }

		// ENGINE_VAR d3d_near_models;
		public static ackvar D3dNearModels { get { return GetVar(636); } set { SetVar(636, value); } }

		// ENGINE_VAR d3d_triplebuffer;
		public static ackvar D3dTriplebuffer { get { return GetVar(640); } set { SetVar(640, value); } }

		// ENGINE_VECTOR d3d_lodfactor;
		public static Vector D3dLodfactor { get { return GetVector(644); } set { SetVector(644, value); } }

		// ENGINE_VECTOR d3d_pointlightfalloff;
		public static Vector D3dPointlightfalloff { get { return GetVector(648); } set { SetVector(648, value); } }

		// ENGINE_VECTOR d3d_spotlightfalloff;
		public static Vector D3dSpotlightfalloff { get { return GetVector(652); } set { SetVector(652, value); } }

		// ENGINE_VECTOR d3d_spotlightcone;
		public static Vector D3dSpotlightcone { get { return GetVector(656); } set { SetVector(656, value); } }

		// ENGINE_VAR tree_range;
		public static ackvar TreeRange { get { return GetVar(660); } set { SetVar(660, value); } }

		// ENGINE_VAR clip_factor;
		public static ackvar ClipFactor { get { return GetVar(664); } set { SetVar(664, value); } }

		// ENGINE_VAR clip_particles;
		public static ackvar ClipParticles { get { return GetVar(668); } set { SetVar(668, value); } }

		// ENGINE_VAR d3d_near_decals;
		public static ackvar D3dNearDecals { get { return GetVar(672); } set { SetVar(672, value); } }

		// ENGINE_VAR floor_range;
		public static ackvar FloorRange { get { return GetVar(676); } set { SetVar(676, value); } }

		// ENGINE_VAR particle_mode;
		public static ackvar ParticleMode { get { return GetVar(680); } set { SetVar(680, value); } }

		// ENGINE_VAR mip_shaded;
		public static ackvar MipShaded { get { return GetVar(684); } set { SetVar(684, value); } }

		// ENGINE_VAR mip_flat;
		public static ackvar MipFlat { get { return GetVar(688); } set { SetVar(688, value); } }

		// ENGINE_VAR mip_sprites;
		public static ackvar MipSprites { get { return GetVar(692); } set { SetVar(692, value); } }

		// ENGINE_VAR shadow_mode;
		public static ackvar ShadowMode { get { return GetVar(696); } set { SetVar(696, value); } }

		// ENGINE_VAR group_mode;
		public static ackvar GroupMode { get { return GetVar(700); } set { SetVar(700, value); } }

		// ENGINE_VAR max_particles;
		public static ackvar MaxParticles { get { return GetVar(704); } set { SetVar(704, value); } }

		// ENGINE_VAR max_entities;
		public static ackvar MaxEntities { get { return GetVar(708); } set { SetVar(708, value); } }

		// ENGINE_VAR max_lights;
		public static ackvar MaxLights { get { return GetVar(712); } set { SetVar(712, value); } }

		// ENGINE_COLOR sky_color;
		public static Color SkyColor { get { return (Color)GetVector(716); } set { SetVector(716, (Vector)value); } }

		// ENGINE_VAR max_bones;
		public static ackvar MaxBones { get { return GetVar(720); } set { SetVar(720, value); } }

		// ENGINE_VAR sky_blend;
		public static ackvar SkyBlend { get { return GetVar(724); } set { SetVar(724, value); } }

		// ENGINE_VECTOR sky_speed;
		public static Vector SkySpeed { get { return GetVector(728); } set { SetVector(728, value); } }

		// ENGINE_VECTOR cloud_speed;
		public static Vector CloudSpeed { get { return GetVector(732); } set { SetVector(732, value); } }

		// ENGINE_VAR d3d_skydepth;
		public static ackvar D3dSkydepth { get { return GetVar(736); } set { SetVar(736, value); } }

		// ENGINE_VAR sky_curve;
		public static ackvar SkyCurve { get { return GetVar(740); } set { SetVar(740, value); } }

		// ENGINE_VAR sky_clip;
		public static ackvar SkyClip { get { return GetVar(744); } set { SetVar(744, value); } }

		// ENGINE_VAR terrain_chunk;
		public static ackvar TerrainChunk { get { return GetVar(748); } set { SetVar(748, value); } }

		// ENGINE_VAR terrain_lod;
		public static ackvar TerrainLod { get { return GetVar(752); } set { SetVar(752, value); } }

		// ENGINE_VAR num_lights;
		public static ackvar NumLights { get { return GetVar(756); } set { SetVar(756, value); } }

		// ENGINE_VAR num_sounds;
		public static ackvar NumSounds { get { return GetVar(760); } set { SetVar(760, value); } }

		// ENGINE_VAR sun_light;
		public static ackvar SunLight { get { return GetVar(764); } set { SetVar(764, value); } }

		// ENGINE_COLOR sun_color;
		public static Color SunColor { get { return (Color)GetVector(768); } set { SetVector(768, (Vector)value); } }

		// ENGINE_ANGLE sun_angle;
		public static Angle SunAngle { get { return (Angle)GetVector(772); } set { SetVector(772, (Vector)value); } }

		// ENGINE_VECTOR sun_pos;
		public static Vector SunPos { get { return GetVector(776); } set { SetVector(776, value); } }

		// ENGINE_VAR preload_mode;
		public static ackvar PreloadMode { get { return GetVar(780); } set { SetVar(780, value); } }

		// ENGINE_VAR fog_color;
		public static ackvar FogColor { get { return GetVar(784); } set { SetVar(784, value); } }

		// ENGINE_COLOR d3d_fogcolor1;
		public static Color D3dFogcolor1 { get { return (Color)GetVector(788); } set { SetVector(788, (Vector)value); } }

		// ENGINE_COLOR d3d_fogcolor2;
		public static Color D3dFogcolor2 { get { return (Color)GetVector(792); } set { SetVector(792, (Vector)value); } }

		// ENGINE_COLOR d3d_fogcolor3;
		public static Color D3dFogcolor3 { get { return (Color)GetVector(796); } set { SetVector(796, (Vector)value); } }

		// ENGINE_COLOR d3d_fogcolor4;
		public static Color D3dFogcolor4 { get { return (Color)GetVector(800); } set { SetVector(800, (Vector)value); } }

		// ENGINE_VAR max_paths;
		public static ackvar MaxPaths { get { return GetVar(804); } set { SetVar(804, value); } }

		// ENGINE_VAR num_paths;
		public static ackvar NumPaths { get { return GetVar(808); } set { SetVar(808, value); } }

		// ENGINE_VAR tex_cycles;
		public static ackvar TexCycles { get { return GetVar(812); } set { SetVar(812, value); } }

		// ENGINE_VAR detail_size;
		public static ackvar DetailSize { get { return GetVar(816); } set { SetVar(816, value); } }

		// ENGINE_VAR pos_resolution;
		public static ackvar PosResolution { get { return GetVar(820); } set { SetVar(820, value); } }

		// ENGINE_VAR tex_share;
		public static ackvar TexShare { get { return GetVar(824); } set { SetVar(824, value); } }

		// ENGINE_VAR map_subents;
		public static ackvar MapSubents { get { return GetVar(828); } set { SetVar(828, value); } }

		// ENGINE_VAR num_particles;
		public static ackvar NumParticles { get { return GetVar(832); } set { SetVar(832, value); } }

		// ENGINE_VAR num_entities;
		public static ackvar NumEntities { get { return GetVar(836); } set { SetVar(836, value); } }

		// ENGINE_VAR num_visents;
		public static ackvar NumVisents { get { return GetVar(840); } set { SetVar(840, value); } }

		// ENGINE_VAR num_vismappolys;
		public static ackvar NumVismappolys { get { return GetVar(844); } set { SetVar(844, value); } }

		// ENGINE_VAR num_visentpolys;
		public static ackvar NumVisentpolys { get { return GetVar(848); } set { SetVar(848, value); } }

		// ENGINE_VAR num_vistriangles;
		public static ackvar NumVistriangles { get { return GetVar(852); } set { SetVar(852, value); } }

		// ENGINE_VAR num_actions;
		public static ackvar NumActions { get { return GetVar(856); } set { SetVar(856, value); } }

		// ENGINE_VAR connection;
		public static ackvar Connection { get { return GetVar(860); } set { SetVar(860, value); } }

		// ENGINE_VAR dplay_maxclients;
		public static ackvar DplayMaxclients { get { return GetVar(864); } set { SetVar(864, value); } }

		// ENGINE_VAR dplay_bandwidth;
		public static ackvar DplayBandwidth { get { return GetVar(868); } set { SetVar(868, value); } }

		// ENGINE_VAR dplay_unreliable;
		public static ackvar DplayUnreliable { get { return GetVar(872); } set { SetVar(872, value); } }

		// ENGINE_VAR dplay_smooth;
		public static ackvar DplaySmooth { get { return GetVar(876); } set { SetVar(876, value); } }

		// ENGINE_VAR dplay_localfunction;
		public static ackvar DplayLocalfunction { get { return GetVar(880); } set { SetVar(880, value); } }

		// ENGINE_VAR dplay_compression;
		public static ackvar DplayCompression { get { return GetVar(884); } set { SetVar(884, value); } }

		// ENGINE_VAR dplay_entupdate;
		public static ackvar DplayEntupdate { get { return GetVar(888); } set { SetVar(888, value); } }

		// ENGINE_VAR dplay_pingrate;
		public static ackvar DplayPingrate { get { return GetVar(892); } set { SetVar(892, value); } }

		// ENGINE_VAR dplay_entrate;
		public static ackvar DplayEntrate { get { return GetVar(896); } set { SetVar(896, value); } }

		// ENGINE_VAR dplay_packetsize;
		public static ackvar DplayPacketsize { get { return GetVar(900); } set { SetVar(900, value); } }

		// ENGINE_VAR dplay_timeout;
		public static ackvar DplayTimeout { get { return GetVar(904); } set { SetVar(904, value); } }

		// ENGINE_VAR dplay_latency;
		public static ackvar DplayLatency { get { return GetVar(908); } set { SetVar(908, value); } }

		// ENGINE_VAR dplay_bps;
		public static ackvar DplayBps { get { return GetVar(912); } set { SetVar(912, value); } }

		// ENGINE_VAR dplay_bpspeak;
		public static ackvar DplayBpspeak { get { return GetVar(916); } set { SetVar(916, value); } }

		// ENGINE_VAR dplay_bpsreliable;
		public static ackvar DplayBpsreliable { get { return GetVar(920); } set { SetVar(920, value); } }

		// ENGINE_VAR dplay_bpsunreliable;
		public static ackvar DplayBpsunreliable { get { return GetVar(924); } set { SetVar(924, value); } }

		// ENGINE_VAR dplay_dropped;
		public static ackvar DplayDropped { get { return GetVar(928); } set { SetVar(928, value); } }

		// ENGINE_VAR recbuf_size;
		public static ackvar RecbufSize { get { return GetVar(932); } set { SetVar(932, value); } }

		// ENGINE_VAR dplay_diag;
		public static ackvar DplayDiag { get { return GetVar(936); } set { SetVar(936, value); } }

		// ENGINE_VAR num_clients;
		public static ackvar NumClients { get { return GetVar(940); } set { SetVar(940, value); } }

		// ENGINE_VAR dplay_encrypt;
		public static ackvar DplayEncrypt { get { return GetVar(944); } set { SetVar(944, value); } }

		// ENGINE_VAR dplay_port;
		public static ackvar DplayPort { get { return GetVar(948); } set { SetVar(948, value); } }

		// ENGINE_VAR dplay_id;
		public static ackvar DplayId { get { return GetVar(952); } set { SetVar(952, value); } }

		// ENGINE_VAR dplay_status;
		public static ackvar DplayStatus { get { return GetVar(956); } set { SetVar(956, value); } }

		// ENGINE_VAR reserved63;

		// ENGINE_VAR sound_vol;
		public static ackvar SoundVol { get { return GetVar(964); } set { SetVar(964, value); } }

		// ENGINE_VAR cdaudio_vol;
		public static ackvar CdaudioVol { get { return GetVar(968); } set { SetVar(968, value); } }

		// ENGINE_VAR midi_vol;
		public static ackvar MidiVol { get { return GetVar(972); } set { SetVar(972, value); } }

		// ENGINE_VAR media_handle;
		public static ackvar MediaHandle { get { return GetVar(976); } set { SetVar(976, value); } }

		// ENGINE_VAR media_layer;
		public static ackvar MediaLayer { get { return GetVar(980); } set { SetVar(980, value); } }

		// ENGINE_VAR num_mediastreams;
		public static ackvar NumMediastreams { get { return GetVar(984); } set { SetVar(984, value); } }

		// ENGINE_VAR doppler_factor;
		public static ackvar DopplerFactor { get { return GetVar(988); } set { SetVar(988, value); } }

		// ENGINE_VAR master_vol;
		public static ackvar MasterVol { get { return GetVar(992); } set { SetVar(992, value); } }

		// ENGINE_VAR video_alpha;
		public static ackvar VideoAlpha { get { return GetVar(996); } set { SetVar(996, value); } }

		// ENGINE_VAR reserved64;

		// ENGINE_VECTOR hull_fatmin;
		public static Vector HullFatmin { get { return GetVector(1004); } set { SetVector(1004, value); } }

		// ENGINE_VECTOR hull_fatmax;
		public static Vector HullFatmax { get { return GetVector(1008); } set { SetVector(1008, value); } }

		// ENGINE_VECTOR hull_narrowmin;
		public static Vector HullNarrowmin { get { return GetVector(1012); } set { SetVector(1012, value); } }

		// ENGINE_VECTOR hull_narrowmax;
		public static Vector HullNarrowmax { get { return GetVector(1016); } set { SetVector(1016, value); } }

		// ENGINE_VAR max_ph_entities;
		public static ackvar MaxPhEntities { get { return GetVar(1020); } set { SetVar(1020, value); } }

		// ENGINE_VAR collision_mode;
		public static ackvar CollisionMode { get { return GetVar(1024); } set { SetVar(1024, value); } }

		// ENGINE_VAR trace_mode;
		public static ackvar TraceMode { get { return GetVar(1028); } set { SetVar(1028, value); } }

		// ENGINE_VAR move_mode;
		public static ackvar MoveMode { get { return GetVar(1032); } set { SetVar(1032, value); } }

		// ENGINE_VAR move_friction;
		public static ackvar MoveFriction { get { return GetVar(1036); } set { SetVar(1036, value); } }

		// ENGINE_VAR move_restrict;
		public static ackvar MoveRestrict { get { return GetVar(1040); } set { SetVar(1040, value); } }

		// ENGINE_VECTOR normal;
		public static Vector Normal { get { return GetVector(1044); } set { SetVector(1044, value); } }

		// ENGINE_VECTOR bounce;
		public static Vector Bounce { get { return GetVector(1048); } set { SetVector(1048, value); } }

		// ENGINE_VECTOR target;
		public static Vector Target { get { return GetVector(1052); } set { SetVector(1052, value); } }

		// ENGINE_VECTOR vglide;
		public static Vector Vglide { get { return GetVector(1056); } set { SetVector(1056, value); } }

		// ENGINE_VAR on_passable;
		public static ackvar OnPassable { get { return GetVar(1060); } set { SetVar(1060, value); } }

		// ENGINE_VAR in_passable;
		public static ackvar InPassable { get { return GetVar(1064); } set { SetVar(1064, value); } }

		// ENGINE_VAR in_solid;
		public static ackvar InSolid { get { return GetVar(1068); } set { SetVar(1068, value); } }

		// ENGINE_VAR tex_light;
		public static ackvar TexLight { get { return GetVar(1072); } set { SetVar(1072, value); } }

		// ENGINE_COLOR tex_color;
		public static Color TexColor { get { return (Color)GetVector(1076); } set { SetVector(1076, (Vector)value); } }

		// ENGINE_VAR tex_fog;
		public static ackvar TexFog { get { return GetVar(1080); } set { SetVar(1080, value); } }

		// ENGINE_VAR tex_flag1;
		public static ackvar TexFlag1 { get { return GetVar(1084); } set { SetVar(1084, value); } }

		// ENGINE_VAR tex_flag2;
		public static ackvar TexFlag2 { get { return GetVar(1088); } set { SetVar(1088, value); } }

		// ENGINE_VAR tex_flag3;
		public static ackvar TexFlag3 { get { return GetVar(1092); } set { SetVar(1092, value); } }

		// ENGINE_VAR tex_flag4;
		public static ackvar TexFlag4 { get { return GetVar(1096); } set { SetVar(1096, value); } }

		// ENGINE_VAR tex_flag5;
		public static ackvar TexFlag5 { get { return GetVar(1100); } set { SetVar(1100, value); } }

		// ENGINE_VAR tex_flag6;
		public static ackvar TexFlag6 { get { return GetVar(1104); } set { SetVar(1104, value); } }

		// ENGINE_VAR tex_flag7;
		public static ackvar TexFlag7 { get { return GetVar(1108); } set { SetVar(1108, value); } }

		// ENGINE_VAR tex_flag8;
		public static ackvar TexFlag8 { get { return GetVar(1112); } set { SetVar(1112, value); } }

		// ENGINE_VAR hitvertex;
		public static ackvar Hitvertex { get { return GetVar(1116); } set { SetVar(1116, value); } }

		// ENGINE_VAR terrain_cell_size;
		public static ackvar TerrainCellSize { get { return GetVar(1120); } set { SetVar(1120, value); } }

		// ENGINE_VAR trace_hit;
		public static ackvar TraceHit { get { return GetVar(1124); } set { SetVar(1124, value); } }

		// ENGINE_VAR num_bodies;
		public static ackvar NumBodies { get { return GetVar(1128); } set { SetVar(1128, value); } }

		// ENGINE_VAR num_contacts;
		public static ackvar NumContacts { get { return GetVar(1132); } set { SetVar(1132, value); } }

		// ENGINE_VAR ph_iterations;
		public static ackvar PhIterations { get { return GetVar(1136); } set { SetVar(1136, value); } }

		// ENGINE_VAR ph_fps_max_lock;
		public static ackvar PhFpsMaxLock { get { return GetVar(1140); } set { SetVar(1140, value); } }

		// ENGINE_VAR move_min_z;
		public static ackvar MoveMinZ { get { return GetVar(1144); } set { SetVar(1144, value); } }

		// ENGINE_VAR disable_z_glide;
		public static ackvar DisableZGlide { get { return GetVar(1148); } set { SetVar(1148, value); } }

		// ENGINE_VAR ph_max_contacts;
		public static ackvar PhMaxContacts { get { return GetVar(1152); } set { SetVar(1152, value); } }

		// ENGINE_VAR ph_check_distance;
		public static ackvar PhCheckDistance { get { return GetVar(1156); } set { SetVar(1156, value); } }

		// ENGINE_VAR ph_num_collisions;
		public static ackvar PhNumCollisions { get { return GetVar(1160); } set { SetVar(1160, value); } }

		// ENGINE_VAR move_pushback;
		public static ackvar MovePushback { get { return GetVar(1164); } set { SetVar(1164, value); } }

		// ENGINE_VAR shadow_meshsize;
		public static ackvar ShadowMeshsize { get { return GetVar(1168); } set { SetVar(1168, value); } }

		// ENGINE_VAR security_mode;
		public static ackvar SecurityMode { get { return GetVar(1172); } set { SetVar(1172, value); } }

		// ENGINE_VAR last_skill;
		public static ackvar LastSkill { get { return GetVar(1176); } set { SetVar(1176, value); } }

		// ENGINE_VAR key_bksp;
		public static ackvar KeyBksp { get { return GetVar(1236); } set { SetVar(1236, value); } }

		// ENGINE_VAR key_enter;
		public static ackvar KeyEnter { get { return GetVar(1240); } set { SetVar(1240, value); } }

		// ENGINE_VAR key_esc;
		public static ackvar KeyEsc { get { return GetVar(1244); } set { SetVar(1244, value); } }

		// ENGINE_VAR key_alt;
		public static ackvar KeyAlt { get { return GetVar(1248); } set { SetVar(1248, value); } }

		// ENGINE_VAR key_ctrl;
		public static ackvar KeyCtrl { get { return GetVar(1252); } set { SetVar(1252, value); } }

		// ENGINE_VAR key_shiftl;
		public static ackvar KeyShiftl { get { return GetVar(1256); } set { SetVar(1256, value); } }

		// ENGINE_VAR key_shiftr;
		public static ackvar KeyShiftr { get { return GetVar(1260); } set { SetVar(1260, value); } }

		// ENGINE_VAR key_space;
		public static ackvar KeySpace { get { return GetVar(1264); } set { SetVar(1264, value); } }

		// ENGINE_VAR key_tab;
		public static ackvar KeyTab { get { return GetVar(1268); } set { SetVar(1268, value); } }

		// ENGINE_VAR key_f1;
		public static ackvar KeyF1 { get { return GetVar(1272); } set { SetVar(1272, value); } }

		// ENGINE_VAR key_f2;
		public static ackvar KeyF2 { get { return GetVar(1276); } set { SetVar(1276, value); } }

		// ENGINE_VAR key_f3;
		public static ackvar KeyF3 { get { return GetVar(1280); } set { SetVar(1280, value); } }

		// ENGINE_VAR key_f4;
		public static ackvar KeyF4 { get { return GetVar(1284); } set { SetVar(1284, value); } }

		// ENGINE_VAR key_f5;
		public static ackvar KeyF5 { get { return GetVar(1288); } set { SetVar(1288, value); } }

		// ENGINE_VAR key_f6;
		public static ackvar KeyF6 { get { return GetVar(1292); } set { SetVar(1292, value); } }

		// ENGINE_VAR key_f7;
		public static ackvar KeyF7 { get { return GetVar(1296); } set { SetVar(1296, value); } }

		// ENGINE_VAR key_f8;
		public static ackvar KeyF8 { get { return GetVar(1300); } set { SetVar(1300, value); } }

		// ENGINE_VAR key_f9;
		public static ackvar KeyF9 { get { return GetVar(1304); } set { SetVar(1304, value); } }

		// ENGINE_VAR key_f10;
		public static ackvar KeyF10 { get { return GetVar(1308); } set { SetVar(1308, value); } }

		// ENGINE_VAR key_f11;
		public static ackvar KeyF11 { get { return GetVar(1312); } set { SetVar(1312, value); } }

		// ENGINE_VAR key_f12;
		public static ackvar KeyF12 { get { return GetVar(1316); } set { SetVar(1316, value); } }

		// ENGINE_VAR key_a;
		public static ackvar KeyA { get { return GetVar(1320); } set { SetVar(1320, value); } }

		// ENGINE_VAR key_b;
		public static ackvar KeyB { get { return GetVar(1324); } set { SetVar(1324, value); } }

		// ENGINE_VAR key_c;
		public static ackvar KeyC { get { return GetVar(1328); } set { SetVar(1328, value); } }

		// ENGINE_VAR key_d;
		public static ackvar KeyD { get { return GetVar(1332); } set { SetVar(1332, value); } }

		// ENGINE_VAR key_e;
		public static ackvar KeyE { get { return GetVar(1336); } set { SetVar(1336, value); } }

		// ENGINE_VAR key_f;
		public static ackvar KeyF { get { return GetVar(1340); } set { SetVar(1340, value); } }

		// ENGINE_VAR key_g;
		public static ackvar KeyG { get { return GetVar(1344); } set { SetVar(1344, value); } }

		// ENGINE_VAR key_h;
		public static ackvar KeyH { get { return GetVar(1348); } set { SetVar(1348, value); } }

		// ENGINE_VAR key_i;
		public static ackvar KeyI { get { return GetVar(1352); } set { SetVar(1352, value); } }

		// ENGINE_VAR key_j;
		public static ackvar KeyJ { get { return GetVar(1356); } set { SetVar(1356, value); } }

		// ENGINE_VAR key_k;
		public static ackvar KeyK { get { return GetVar(1360); } set { SetVar(1360, value); } }

		// ENGINE_VAR key_l;
		public static ackvar KeyL { get { return GetVar(1364); } set { SetVar(1364, value); } }

		// ENGINE_VAR key_m;
		public static ackvar KeyM { get { return GetVar(1368); } set { SetVar(1368, value); } }

		// ENGINE_VAR key_n;
		public static ackvar KeyN { get { return GetVar(1372); } set { SetVar(1372, value); } }

		// ENGINE_VAR key_o;
		public static ackvar KeyO { get { return GetVar(1376); } set { SetVar(1376, value); } }

		// ENGINE_VAR key_p;
		public static ackvar KeyP { get { return GetVar(1380); } set { SetVar(1380, value); } }

		// ENGINE_VAR key_q;
		public static ackvar KeyQ { get { return GetVar(1384); } set { SetVar(1384, value); } }

		// ENGINE_VAR key_r;
		public static ackvar KeyR { get { return GetVar(1388); } set { SetVar(1388, value); } }

		// ENGINE_VAR key_s;
		public static ackvar KeyS { get { return GetVar(1392); } set { SetVar(1392, value); } }

		// ENGINE_VAR key_t;
		public static ackvar KeyT { get { return GetVar(1396); } set { SetVar(1396, value); } }

		// ENGINE_VAR key_u;
		public static ackvar KeyU { get { return GetVar(1400); } set { SetVar(1400, value); } }

		// ENGINE_VAR key_v;
		public static ackvar KeyV { get { return GetVar(1404); } set { SetVar(1404, value); } }

		// ENGINE_VAR key_w;
		public static ackvar KeyW { get { return GetVar(1408); } set { SetVar(1408, value); } }

		// ENGINE_VAR key_x;
		public static ackvar KeyX { get { return GetVar(1412); } set { SetVar(1412, value); } }

		// ENGINE_VAR key_y;
		public static ackvar KeyY { get { return GetVar(1416); } set { SetVar(1416, value); } }

		// ENGINE_VAR key_z;
		public static ackvar KeyZ { get { return GetVar(1420); } set { SetVar(1420, value); } }

		// ENGINE_VAR key_cuu;
		public static ackvar KeyCuu { get { return GetVar(1424); } set { SetVar(1424, value); } }

		// ENGINE_VAR key_cud;
		public static ackvar KeyCud { get { return GetVar(1428); } set { SetVar(1428, value); } }

		// ENGINE_VAR key_cur;
		public static ackvar KeyCur { get { return GetVar(1432); } set { SetVar(1432, value); } }

		// ENGINE_VAR key_cul;
		public static ackvar KeyCul { get { return GetVar(1436); } set { SetVar(1436, value); } }

		// ENGINE_VAR key_pgup;
		public static ackvar KeyPgup { get { return GetVar(1440); } set { SetVar(1440, value); } }

		// ENGINE_VAR key_pgdn;
		public static ackvar KeyPgdn { get { return GetVar(1444); } set { SetVar(1444, value); } }

		// ENGINE_VAR key_home;
		public static ackvar KeyHome { get { return GetVar(1448); } set { SetVar(1448, value); } }

		// ENGINE_VAR key_end;
		public static ackvar KeyEnd { get { return GetVar(1452); } set { SetVar(1452, value); } }

		// ENGINE_VAR key_ins;
		public static ackvar KeyIns { get { return GetVar(1456); } set { SetVar(1456, value); } }

		// ENGINE_VAR key_del;
		public static ackvar KeyDel { get { return GetVar(1460); } set { SetVar(1460, value); } }

		// ENGINE_VAR key_car;
		public static ackvar KeyCar { get { return GetVar(1464); } set { SetVar(1464, value); } }

		// ENGINE_VAR key_cal;
		public static ackvar KeyCal { get { return GetVar(1468); } set { SetVar(1468, value); } }

		// ENGINE_VAR key_slash;
		public static ackvar KeySlash { get { return GetVar(1472); } set { SetVar(1472, value); } }

		// ENGINE_VAR key_equals;
		public static ackvar KeyEquals { get { return GetVar(1476); } set { SetVar(1476, value); } }

		// ENGINE_VAR key_period;
		public static ackvar KeyPeriod { get { return GetVar(1480); } set { SetVar(1480, value); } }

		// ENGINE_VAR key_comma;
		public static ackvar KeyComma { get { return GetVar(1484); } set { SetVar(1484, value); } }

		// ENGINE_VAR key_brackl;
		public static ackvar KeyBrackl { get { return GetVar(1488); } set { SetVar(1488, value); } }

		// ENGINE_VAR key_brackr;
		public static ackvar KeyBrackr { get { return GetVar(1492); } set { SetVar(1492, value); } }

		// ENGINE_VAR key_semic;
		public static ackvar KeySemic { get { return GetVar(1496); } set { SetVar(1496, value); } }

		// ENGINE_VAR key_bksl;
		public static ackvar KeyBksl { get { return GetVar(1500); } set { SetVar(1500, value); } }

		// ENGINE_VAR key_apos;
		public static ackvar KeyApos { get { return GetVar(1504); } set { SetVar(1504, value); } }

		// ENGINE_VAR key_minusc;
		public static ackvar KeyMinusc { get { return GetVar(1508); } set { SetVar(1508, value); } }

		// ENGINE_VAR key_grave;
		public static ackvar KeyGrave { get { return GetVar(1512); } set { SetVar(1512, value); } }

		// ENGINE_VAR key_caps;
		public static ackvar KeyCaps { get { return GetVar(1516); } set { SetVar(1516, value); } }

		// ENGINE_VAR key_scrlk;
		public static ackvar KeyScrlk { get { return GetVar(1520); } set { SetVar(1520, value); } }

		// ENGINE_VAR key_plus;
		public static ackvar KeyPlus { get { return GetVar(1524); } set { SetVar(1524, value); } }

		// ENGINE_VAR key_sz;
		public static ackvar KeySz { get { return GetVar(1528); } set { SetVar(1528, value); } }

		// ENGINE_VAR key_ae;
		public static ackvar KeyAe { get { return GetVar(1532); } set { SetVar(1532, value); } }

		// ENGINE_VAR key_ue;
		public static ackvar KeyUe { get { return GetVar(1536); } set { SetVar(1536, value); } }

		// ENGINE_VAR key_oe;
		public static ackvar KeyOe { get { return GetVar(1540); } set { SetVar(1540, value); } }

		// ENGINE_VAR key_1;
		public static ackvar Key1 { get { return GetVar(1544); } set { SetVar(1544, value); } }

		// ENGINE_VAR key_2;
		public static ackvar Key2 { get { return GetVar(1548); } set { SetVar(1548, value); } }

		// ENGINE_VAR key_3;
		public static ackvar Key3 { get { return GetVar(1552); } set { SetVar(1552, value); } }

		// ENGINE_VAR key_4;
		public static ackvar Key4 { get { return GetVar(1556); } set { SetVar(1556, value); } }

		// ENGINE_VAR key_5;
		public static ackvar Key5 { get { return GetVar(1560); } set { SetVar(1560, value); } }

		// ENGINE_VAR key_6;
		public static ackvar Key6 { get { return GetVar(1564); } set { SetVar(1564, value); } }

		// ENGINE_VAR key_7;
		public static ackvar Key7 { get { return GetVar(1568); } set { SetVar(1568, value); } }

		// ENGINE_VAR key_8;
		public static ackvar Key8 { get { return GetVar(1572); } set { SetVar(1572, value); } }

		// ENGINE_VAR key_9;
		public static ackvar Key9 { get { return GetVar(1576); } set { SetVar(1576, value); } }

		// ENGINE_VAR key_0;
		public static ackvar Key0 { get { return GetVar(1580); } set { SetVar(1580, value); } }

		// ENGINE_VAR key_pause;
		public static ackvar KeyPause { get { return GetVar(1584); } set { SetVar(1584, value); } }

		// ENGINE_VAR mouse_left;
		public static ackvar MouseLeft { get { return GetVar(1588); } set { SetVar(1588, value); } }

		// ENGINE_VAR mouse_right;
		public static ackvar MouseRight { get { return GetVar(1592); } set { SetVar(1592, value); } }

		// ENGINE_VAR mouse_middle;
		public static ackvar MouseMiddle { get { return GetVar(1596); } set { SetVar(1596, value); } }

		// ENGINE_VAR joy_1;
		public static ackvar Joy1 { get { return GetVar(1600); } set { SetVar(1600, value); } }

		// ENGINE_VAR joy_2;
		public static ackvar Joy2 { get { return GetVar(1604); } set { SetVar(1604, value); } }

		// ENGINE_VAR joy_3;
		public static ackvar Joy3 { get { return GetVar(1608); } set { SetVar(1608, value); } }

		// ENGINE_VAR joy_4;
		public static ackvar Joy4 { get { return GetVar(1612); } set { SetVar(1612, value); } }

		// ENGINE_VAR joy_5;
		public static ackvar Joy5 { get { return GetVar(1616); } set { SetVar(1616, value); } }

		// ENGINE_VAR joy_6;
		public static ackvar Joy6 { get { return GetVar(1620); } set { SetVar(1620, value); } }

		// ENGINE_VAR joy_7;
		public static ackvar Joy7 { get { return GetVar(1624); } set { SetVar(1624, value); } }

		// ENGINE_VAR joy_8;
		public static ackvar Joy8 { get { return GetVar(1628); } set { SetVar(1628, value); } }

		// ENGINE_VAR joy_9;
		public static ackvar Joy9 { get { return GetVar(1632); } set { SetVar(1632, value); } }

		// ENGINE_VAR joy_10;
		public static ackvar Joy10 { get { return GetVar(1636); } set { SetVar(1636, value); } }

		// ENGINE_VAR joy_11;
		public static ackvar Joy11 { get { return GetVar(1640); } set { SetVar(1640, value); } }

		// ENGINE_VAR joy_12;
		public static ackvar Joy12 { get { return GetVar(1644); } set { SetVar(1644, value); } }

		// ENGINE_VAR joy2_1;
		public static ackvar Joy21 { get { return GetVar(1648); } set { SetVar(1648, value); } }

		// ENGINE_VAR joy2_2;
		public static ackvar Joy22 { get { return GetVar(1652); } set { SetVar(1652, value); } }

		// ENGINE_VAR joy2_3;
		public static ackvar Joy23 { get { return GetVar(1656); } set { SetVar(1656, value); } }

		// ENGINE_VAR joy2_4;
		public static ackvar Joy24 { get { return GetVar(1660); } set { SetVar(1660, value); } }

		// ENGINE_VAR joy2_5;
		public static ackvar Joy25 { get { return GetVar(1664); } set { SetVar(1664, value); } }

		// ENGINE_VAR joy2_6;
		public static ackvar Joy26 { get { return GetVar(1668); } set { SetVar(1668, value); } }

		// ENGINE_VAR joy2_7;
		public static ackvar Joy27 { get { return GetVar(1672); } set { SetVar(1672, value); } }

		// ENGINE_VAR joy2_8;
		public static ackvar Joy28 { get { return GetVar(1676); } set { SetVar(1676, value); } }

		// ENGINE_VAR joy2_9;
		public static ackvar Joy29 { get { return GetVar(1680); } set { SetVar(1680, value); } }

		// ENGINE_VAR joy2_10;
		public static ackvar Joy210 { get { return GetVar(1684); } set { SetVar(1684, value); } }

		// ENGINE_VAR joy2_11;
		public static ackvar Joy211 { get { return GetVar(1688); } set { SetVar(1688, value); } }

		// ENGINE_VAR joy2_12;
		public static ackvar Joy212 { get { return GetVar(1692); } set { SetVar(1692, value); } }

		// ENGINE_EVENT on_bksp;
		private static EngineEventDelegate onBksp;
		public static event EventHandler<EngineEventArgs> OnBksp;

		// ENGINE_EVENT on_enter;
		private static EngineEventDelegate onEnter;
		public static event EventHandler<EngineEventArgs> OnEnter;

		// ENGINE_EVENT on_esc;
		private static EngineEventDelegate onEsc;
		public static event EventHandler<EngineEventArgs> OnEsc;

		// ENGINE_EVENT on_alt;
		private static EngineEventDelegate onAlt;
		public static event EventHandler<EngineEventArgs> OnAlt;

		// ENGINE_EVENT on_ctrl;
		private static EngineEventDelegate onCtrl;
		public static event EventHandler<EngineEventArgs> OnCtrl;

		// ENGINE_EVENT on_shiftl;
		private static EngineEventDelegate onShiftl;
		public static event EventHandler<EngineEventArgs> OnShiftl;

		// ENGINE_EVENT on_shiftr;
		private static EngineEventDelegate onShiftr;
		public static event EventHandler<EngineEventArgs> OnShiftr;

		// ENGINE_EVENT on_space;
		private static EngineEventDelegate onSpace;
		public static event EventHandler<EngineEventArgs> OnSpace;

		// ENGINE_EVENT on_tab;
		private static EngineEventDelegate onTab;
		public static event EventHandler<EngineEventArgs> OnTab;

		// ENGINE_EVENT on_f1;
		private static EngineEventDelegate onF1;
		public static event EventHandler<EngineEventArgs> OnF1;

		// ENGINE_EVENT on_f2;
		private static EngineEventDelegate onF2;
		public static event EventHandler<EngineEventArgs> OnF2;

		// ENGINE_EVENT on_f3;
		private static EngineEventDelegate onF3;
		public static event EventHandler<EngineEventArgs> OnF3;

		// ENGINE_EVENT on_f4;
		private static EngineEventDelegate onF4;
		public static event EventHandler<EngineEventArgs> OnF4;

		// ENGINE_EVENT on_f5;
		private static EngineEventDelegate onF5;
		public static event EventHandler<EngineEventArgs> OnF5;

		// ENGINE_EVENT on_f6;
		private static EngineEventDelegate onF6;
		public static event EventHandler<EngineEventArgs> OnF6;

		// ENGINE_EVENT on_f7;
		private static EngineEventDelegate onF7;
		public static event EventHandler<EngineEventArgs> OnF7;

		// ENGINE_EVENT on_f8;
		private static EngineEventDelegate onF8;
		public static event EventHandler<EngineEventArgs> OnF8;

		// ENGINE_EVENT on_f9;
		private static EngineEventDelegate onF9;
		public static event EventHandler<EngineEventArgs> OnF9;

		// ENGINE_EVENT on_f10;
		private static EngineEventDelegate onF10;
		public static event EventHandler<EngineEventArgs> OnF10;

		// ENGINE_EVENT on_f11;
		private static EngineEventDelegate onF11;
		public static event EventHandler<EngineEventArgs> OnF11;

		// ENGINE_EVENT on_f12;
		private static EngineEventDelegate onF12;
		public static event EventHandler<EngineEventArgs> OnF12;

		// ENGINE_EVENT on_a;
		private static EngineEventDelegate onA;
		public static event EventHandler<EngineEventArgs> OnA;

		// ENGINE_EVENT on_b;
		private static EngineEventDelegate onB;
		public static event EventHandler<EngineEventArgs> OnB;

		// ENGINE_EVENT on_c;
		private static EngineEventDelegate onC;
		public static event EventHandler<EngineEventArgs> OnC;

		// ENGINE_EVENT on_d;
		private static EngineEventDelegate onD;
		public static event EventHandler<EngineEventArgs> OnD;

		// ENGINE_EVENT on_e;
		private static EngineEventDelegate onE;
		public static event EventHandler<EngineEventArgs> OnE;

		// ENGINE_EVENT on_f;
		private static EngineEventDelegate onF;
		public static event EventHandler<EngineEventArgs> OnF;

		// ENGINE_EVENT on_g;
		private static EngineEventDelegate onG;
		public static event EventHandler<EngineEventArgs> OnG;

		// ENGINE_EVENT on_h;
		private static EngineEventDelegate onH;
		public static event EventHandler<EngineEventArgs> OnH;

		// ENGINE_EVENT on_i;
		private static EngineEventDelegate onI;
		public static event EventHandler<EngineEventArgs> OnI;

		// ENGINE_EVENT on_j;
		private static EngineEventDelegate onJ;
		public static event EventHandler<EngineEventArgs> OnJ;

		// ENGINE_EVENT on_k;
		private static EngineEventDelegate onK;
		public static event EventHandler<EngineEventArgs> OnK;

		// ENGINE_EVENT on_l;
		private static EngineEventDelegate onL;
		public static event EventHandler<EngineEventArgs> OnL;

		// ENGINE_EVENT on_m;
		private static EngineEventDelegate onM;
		public static event EventHandler<EngineEventArgs> OnM;

		// ENGINE_EVENT on_n;
		private static EngineEventDelegate onN;
		public static event EventHandler<EngineEventArgs> OnN;

		// ENGINE_EVENT on_o;
		private static EngineEventDelegate onO;
		public static event EventHandler<EngineEventArgs> OnO;

		// ENGINE_EVENT on_p;
		private static EngineEventDelegate onP;
		public static event EventHandler<EngineEventArgs> OnP;

		// ENGINE_EVENT on_q;
		private static EngineEventDelegate onQ;
		public static event EventHandler<EngineEventArgs> OnQ;

		// ENGINE_EVENT on_r;
		private static EngineEventDelegate onR;
		public static event EventHandler<EngineEventArgs> OnR;

		// ENGINE_EVENT on_s;
		private static EngineEventDelegate onS;
		public static event EventHandler<EngineEventArgs> OnS;

		// ENGINE_EVENT on_t;
		private static EngineEventDelegate onT;
		public static event EventHandler<EngineEventArgs> OnT;

		// ENGINE_EVENT on_u;
		private static EngineEventDelegate onU;
		public static event EventHandler<EngineEventArgs> OnU;

		// ENGINE_EVENT on_v;
		private static EngineEventDelegate onV;
		public static event EventHandler<EngineEventArgs> OnV;

		// ENGINE_EVENT on_w;
		private static EngineEventDelegate onW;
		public static event EventHandler<EngineEventArgs> OnW;

		// ENGINE_EVENT on_x;
		private static EngineEventDelegate onX;
		public static event EventHandler<EngineEventArgs> OnX;

		// ENGINE_EVENT on_y;
		private static EngineEventDelegate onY;
		public static event EventHandler<EngineEventArgs> OnY;

		// ENGINE_EVENT on_z;
		private static EngineEventDelegate onZ;
		public static event EventHandler<EngineEventArgs> OnZ;

		// ENGINE_EVENT on_cuu;
		private static EngineEventDelegate onCuu;
		public static event EventHandler<EngineEventArgs> OnCuu;

		// ENGINE_EVENT on_cud;
		private static EngineEventDelegate onCud;
		public static event EventHandler<EngineEventArgs> OnCud;

		// ENGINE_EVENT on_cur;
		private static EngineEventDelegate onCur;
		public static event EventHandler<EngineEventArgs> OnCur;

		// ENGINE_EVENT on_cul;
		private static EngineEventDelegate onCul;
		public static event EventHandler<EngineEventArgs> OnCul;

		// ENGINE_EVENT on_pgup;
		private static EngineEventDelegate onPgup;
		public static event EventHandler<EngineEventArgs> OnPgup;

		// ENGINE_EVENT on_pgdn;
		private static EngineEventDelegate onPgdn;
		public static event EventHandler<EngineEventArgs> OnPgdn;

		// ENGINE_EVENT on_home;
		private static EngineEventDelegate onHome;
		public static event EventHandler<EngineEventArgs> OnHome;

		// ENGINE_EVENT on_end;
		private static EngineEventDelegate onEnd;
		public static event EventHandler<EngineEventArgs> OnEnd;

		// ENGINE_EVENT on_ins;
		private static EngineEventDelegate onIns;
		public static event EventHandler<EngineEventArgs> OnIns;

		// ENGINE_EVENT on_del;
		private static EngineEventDelegate onDel;
		public static event EventHandler<EngineEventArgs> OnDel;

		// ENGINE_EVENT on_car;
		private static EngineEventDelegate onCar;
		public static event EventHandler<EngineEventArgs> OnCar;

		// ENGINE_EVENT on_cal;
		private static EngineEventDelegate onCal;
		public static event EventHandler<EngineEventArgs> OnCal;

		// ENGINE_EVENT on_slash;
		private static EngineEventDelegate onSlash;
		public static event EventHandler<EngineEventArgs> OnSlash;

		// ENGINE_EVENT on_equals;
		private static EngineEventDelegate onEquals;
		public static event EventHandler<EngineEventArgs> OnEquals;

		// ENGINE_EVENT on_period;
		private static EngineEventDelegate onPeriod;
		public static event EventHandler<EngineEventArgs> OnPeriod;

		// ENGINE_EVENT on_comma;
		private static EngineEventDelegate onComma;
		public static event EventHandler<EngineEventArgs> OnComma;

		// ENGINE_EVENT on_brackl;
		private static EngineEventDelegate onBrackl;
		public static event EventHandler<EngineEventArgs> OnBrackl;

		// ENGINE_EVENT on_brackr;
		private static EngineEventDelegate onBrackr;
		public static event EventHandler<EngineEventArgs> OnBrackr;

		// ENGINE_EVENT on_semic;
		private static EngineEventDelegate onSemic;
		public static event EventHandler<EngineEventArgs> OnSemic;

		// ENGINE_EVENT on_bksl;
		private static EngineEventDelegate onBksl;
		public static event EventHandler<EngineEventArgs> OnBksl;

		// ENGINE_EVENT on_apos;
		private static EngineEventDelegate onApos;
		public static event EventHandler<EngineEventArgs> OnApos;

		// ENGINE_EVENT on_minusc;
		private static EngineEventDelegate onMinusc;
		public static event EventHandler<EngineEventArgs> OnMinusc;

		// ENGINE_EVENT on_grave;
		private static EngineEventDelegate onGrave;
		public static event EventHandler<EngineEventArgs> OnGrave;

		// ENGINE_EVENT on_caps;
		private static EngineEventDelegate onCaps;
		public static event EventHandler<EngineEventArgs> OnCaps;

		// ENGINE_EVENT on_scrlk;
		private static EngineEventDelegate onScrlk;
		public static event EventHandler<EngineEventArgs> OnScrlk;

		// ENGINE_EVENT on_plus;
		private static EngineEventDelegate onPlus;
		public static event EventHandler<EngineEventArgs> OnPlus;

		// ENGINE_EVENT on_sz;
		private static EngineEventDelegate onSz;
		public static event EventHandler<EngineEventArgs> OnSz;

		// ENGINE_EVENT on_ae;
		private static EngineEventDelegate onAe;
		public static event EventHandler<EngineEventArgs> OnAe;

		// ENGINE_EVENT on_ue;
		private static EngineEventDelegate onUe;
		public static event EventHandler<EngineEventArgs> OnUe;

		// ENGINE_EVENT on_oe;
		private static EngineEventDelegate onOe;
		public static event EventHandler<EngineEventArgs> OnOe;

		// ENGINE_EVENT on_1;
		private static EngineEventDelegate on1;
		public static event EventHandler<EngineEventArgs> On1;

		// ENGINE_EVENT on_2;
		private static EngineEventDelegate on2;
		public static event EventHandler<EngineEventArgs> On2;

		// ENGINE_EVENT on_3;
		private static EngineEventDelegate on3;
		public static event EventHandler<EngineEventArgs> On3;

		// ENGINE_EVENT on_4;
		private static EngineEventDelegate on4;
		public static event EventHandler<EngineEventArgs> On4;

		// ENGINE_EVENT on_5;
		private static EngineEventDelegate on5;
		public static event EventHandler<EngineEventArgs> On5;

		// ENGINE_EVENT on_6;
		private static EngineEventDelegate on6;
		public static event EventHandler<EngineEventArgs> On6;

		// ENGINE_EVENT on_7;
		private static EngineEventDelegate on7;
		public static event EventHandler<EngineEventArgs> On7;

		// ENGINE_EVENT on_8;
		private static EngineEventDelegate on8;
		public static event EventHandler<EngineEventArgs> On8;

		// ENGINE_EVENT on_9;
		private static EngineEventDelegate on9;
		public static event EventHandler<EngineEventArgs> On9;

		// ENGINE_EVENT on_0;
		private static EngineEventDelegate on0;
		public static event EventHandler<EngineEventArgs> On0;

		// ENGINE_EVENT on_pause;
		private static EngineEventDelegate onPause;
		public static event EventHandler<EngineEventArgs> OnPause;

		// ENGINE_EVENT on_mouse_left;
		private static EngineEventDelegate onMouseLeft;
		public static event EventHandler<EngineEventArgs> OnMouseLeft;

		// ENGINE_EVENT on_mouse_right;
		private static EngineEventDelegate onMouseRight;
		public static event EventHandler<EngineEventArgs> OnMouseRight;

		// ENGINE_EVENT on_mouse_middle;
		private static EngineEventDelegate onMouseMiddle;
		public static event EventHandler<EngineEventArgs> OnMouseMiddle;

		// ENGINE_EVENT on_joy1;
		private static EngineEventDelegate onJoy1;
		public static event EventHandler<EngineEventArgs> OnJoy1;

		// ENGINE_EVENT on_joy2;
		private static EngineEventDelegate onJoy2;
		public static event EventHandler<EngineEventArgs> OnJoy2;

		// ENGINE_EVENT on_joy3;
		private static EngineEventDelegate onJoy3;
		public static event EventHandler<EngineEventArgs> OnJoy3;

		// ENGINE_EVENT on_joy4;
		private static EngineEventDelegate onJoy4;
		public static event EventHandler<EngineEventArgs> OnJoy4;

		// ENGINE_EVENT on_joy5;
		private static EngineEventDelegate onJoy5;
		public static event EventHandler<EngineEventArgs> OnJoy5;

		// ENGINE_EVENT on_joy6;
		private static EngineEventDelegate onJoy6;
		public static event EventHandler<EngineEventArgs> OnJoy6;

		// ENGINE_EVENT on_joy7;
		private static EngineEventDelegate onJoy7;
		public static event EventHandler<EngineEventArgs> OnJoy7;

		// ENGINE_EVENT on_joy8;
		private static EngineEventDelegate onJoy8;
		public static event EventHandler<EngineEventArgs> OnJoy8;

		// ENGINE_EVENT on_joy9;
		private static EngineEventDelegate onJoy9;
		public static event EventHandler<EngineEventArgs> OnJoy9;

		// ENGINE_EVENT on_joy10;
		private static EngineEventDelegate onJoy10;
		public static event EventHandler<EngineEventArgs> OnJoy10;

		// ENGINE_EVENT on_joy11;
		private static EngineEventDelegate onJoy11;
		public static event EventHandler<EngineEventArgs> OnJoy11;

		// ENGINE_EVENT on_joy12;
		private static EngineEventDelegate onJoy12;
		public static event EventHandler<EngineEventArgs> OnJoy12;

		// ENGINE_EVENT on_joy2_1;
		private static EngineEventDelegate onJoy21;
		public static event EventHandler<EngineEventArgs> OnJoy21;

		// ENGINE_EVENT on_joy2_2;
		private static EngineEventDelegate onJoy22;
		public static event EventHandler<EngineEventArgs> OnJoy22;

		// ENGINE_EVENT on_joy2_3;
		private static EngineEventDelegate onJoy23;
		public static event EventHandler<EngineEventArgs> OnJoy23;

		// ENGINE_EVENT on_joy2_4;
		private static EngineEventDelegate onJoy24;
		public static event EventHandler<EngineEventArgs> OnJoy24;

		// ENGINE_EVENT on_joy2_5;
		private static EngineEventDelegate onJoy25;
		public static event EventHandler<EngineEventArgs> OnJoy25;

		// ENGINE_EVENT on_joy2_6;
		private static EngineEventDelegate onJoy26;
		public static event EventHandler<EngineEventArgs> OnJoy26;

		// ENGINE_EVENT on_joy2_7;
		private static EngineEventDelegate onJoy27;
		public static event EventHandler<EngineEventArgs> OnJoy27;

		// ENGINE_EVENT on_joy2_8;
		private static EngineEventDelegate onJoy28;
		public static event EventHandler<EngineEventArgs> OnJoy28;

		// ENGINE_EVENT on_joy2_9;
		private static EngineEventDelegate onJoy29;
		public static event EventHandler<EngineEventArgs> OnJoy29;

		// ENGINE_EVENT on_joy2_10;
		private static EngineEventDelegate onJoy210;
		public static event EventHandler<EngineEventArgs> OnJoy210;

		// ENGINE_EVENT on_joy2_11;
		private static EngineEventDelegate onJoy211;
		public static event EventHandler<EngineEventArgs> OnJoy211;

		// ENGINE_EVENT on_joy2_12;
		private static EngineEventDelegate onJoy212;
		public static event EventHandler<EngineEventArgs> OnJoy212;

		// ENGINE_EVENT on_anykey;
		private static EngineEventDelegate onAnykey;
		public static event EventHandler<EngineEventArgs> OnAnykey;

		// ENGINE_EVENT on_click;
		private static EngineEventDelegate onClick;
		public static event EventHandler<EngineEventArgs> OnClick;

		// ENGINE_EVENT on_mouse_stop;
		private static EngineEventDelegate onMouseStop;
		public static event EventHandler<EngineEventArgs> OnMouseStop;

		// ENGINE_EVENT on_close;
		private static EngineEventDelegate onClose;
		public static event EventHandler<EngineEventArgs> OnClose;

		// ENGINE_EVENT on_load;
		private static EngineEventDelegate onLoad;
		public static event EventHandler<EngineEventArgs> OnLoad;

		// ENGINE_EVENT on_level;
		private static EngineEventDelegate onLevel;
		public static event EventHandler<EngineEventArgs> OnLevel;

		// ENGINE_EVENT on_server;
		private static EngineEventDelegate onServer;
		public static event EventHandler<EngineEventArgs> OnServer;

		// ENGINE_EVENT on_client;
		private static EngineEventDelegate onClient;
		public static event EventHandler<EngineEventArgs> OnClient;

		// ENGINE_EVENT on_d3d_lost;
		private static EngineEventDelegate onD3dLost;
		public static event EventHandler<EngineEventArgs> OnD3dLost;

		// ENGINE_EVENT on_d3d_reset;
		private static EngineEventDelegate onD3dReset;
		public static event EventHandler<EngineEventArgs> OnD3dReset;

		// ENGINE_EVENT render_sky;
		private static EngineEventDelegate renderSky;
		public static event EventHandler<EngineEventArgs> RenderSky;

		// ENGINE_EVENT render_world;
		private static EngineEventDelegate renderWorld;
		public static event EventHandler<EngineEventArgs> RenderWorld;

		// ENGINE_EVENT render_entities;
		private static EngineEventDelegate renderEntities;
		public static event EventHandler<EngineEventArgs> RenderEntities;

		// ENGINE_EVENT render_solid;
		private static EngineEventDelegate renderSolid;
		public static event EventHandler<EngineEventArgs> RenderSolid;

		// ENGINE_EVENT on_exit;
		private static EngineEventDelegate onExit;
		public static event EventHandler<EngineEventArgs> OnExit;

		// ENGINE_EVENT on_frame;
		private static EngineEventDelegate onFrame;
		public static event EventHandler<EngineEventArgs> OnFrame;

		// ENGINE_EVENT on_message;

		// ENGINE_EVENT on_maximize;
		private static EngineEventDelegate onMaximize;
		public static event EventHandler<EngineEventArgs> OnMaximize;

		// ENGINE_EVENT on_minimize;
		private static EngineEventDelegate onMinimize;
		public static event EventHandler<EngineEventArgs> OnMinimize;

		// ENGINE_EVENT on_resize;
		private static EngineEventDelegate onResize;
		public static event EventHandler<EngineEventArgs> OnResize;

		// ENGINE_EVENT on_level_load;
		private static EngineEventDelegate onLevelLoad;
		public static event EventHandler<EngineEventArgs> OnLevelLoad;

		// ENGINE_EVENT on_ent_remove;
		private static EngineEventDelegate onEntRemove;
		public static event EventHandler<EngineEventArgs> OnEntRemove;

		// ENGINE_EVENT render_layer;
		private static EngineEventDelegate renderLayer;
		public static event EventHandler<EngineEventArgs> RenderLayer;

		// ENGINE_VIEW camera;
		public static View Camera { get { return Get<View>(2328); } set { SetObject(2328, value); } }

		// ENGINE_VIEW light_view;
		public static View LightView { get { return Get<View>(2332); } set { SetObject(2332, value); } }

		// ENGINE_VIEW render_view;
		public static View RenderView { get { return Get<View>(2336); } set { SetObject(2336, value); } }

		// ENGINE_ENTITY watched;
		public static Entity Watched { get { return Get<Entity>(2340); } set { SetObject(2340, value); } }

		// ENGINE_ENTITY me;
		public static Entity Me { get { return Get<Entity>(2344); } set { SetObject(2344, value); } }

		// ENGINE_ENTITY you;
		public static Entity You { get { return Get<Entity>(2348); } set { SetObject(2348, value); } }

		// ENGINE_ENTITY sky_cube_level;
		public static Entity SkyCubeLevel { get { return Get<Entity>(2352); } set { SetObject(2352, value); } }

		// ENGINE_ENTITY sky_dome_level;
		public static Entity SkyDomeLevel { get { return Get<Entity>(2356); } set { SetObject(2356, value); } }

		// ENGINE_ENTITY mouse_ent;
		public static Entity MouseEnt { get { return Get<Entity>(2360); } set { SetObject(2360, value); } }

		// ENGINE_BMAP mouse_map;
		public static Bitmap MouseMap { get { return Get<Bitmap>(2364); } set { SetObject(2364, value); } }

		// void* render_mesh;
		public static IntPtr RenderMesh { get { return GetPtr(2384); } set { SetPtr(2384, value); } }

		// ENGINE_MATERIAL mtl;
		public static Material Mtl { get { return Get<Material>(2388); } set { SetObject(2388, value); } }

		// ENGINE_MATERIAL mtl_flat;
		public static Material MtlFlat { get { return Get<Material>(2392); } set { SetObject(2392, value); } }

		// ENGINE_MATERIAL mtl_shaded;
		public static Material MtlShaded { get { return Get<Material>(2396); } set { SetObject(2396, value); } }

		// ENGINE_MATERIAL mtl_model;
		public static Material MtlModel { get { return Get<Material>(2400); } set { SetObject(2400, value); } }

		// ENGINE_MATERIAL mtl_terrain;
		public static Material MtlTerrain { get { return Get<Material>(2404); } set { SetObject(2404, value); } }

		// ENGINE_MATERIAL mtl_sprite;
		public static Material MtlSprite { get { return Get<Material>(2408); } set { SetObject(2408, value); } }

		// ENGINE_MATERIAL mtl_particle;
		public static Material MtlParticle { get { return Get<Material>(2412); } set { SetObject(2412, value); } }

		// ENGINE_MATERIAL mtl_metal;
		public static Material MtlMetal { get { return Get<Material>(2416); } set { SetObject(2416, value); } }

		// ENGINE_MATERIAL mtl_sky;
		public static Material MtlSky { get { return Get<Material>(2420); } set { SetObject(2420, value); } }

		// ENGINE_MATERIAL mtl_shadow;
		public static Material MtlShadow { get { return Get<Material>(2424); } set { SetObject(2424, value); } }

		// ENGINE_MATERIAL mtl_unlit;
		public static Material MtlUnlit { get { return Get<Material>(2428); } set { SetObject(2428, value); } }

		// ENGINE_STRING debug_str;
		public static AckString DebugStr { get { return Get<AckString>(2432); } set { SetObject(2432, value); } }

		// ENGINE_STRING watch_str;
		public static AckString WatchStr { get { return Get<AckString>(2436); } set { SetObject(2436, value); } }

		// ENGINE_STRING delimit_str;
		public static AckString DelimitStr { get { return Get<AckString>(2440); } set { SetObject(2440, value); } }

		// ENGINE_STRING tex_name;
		public static AckString TexName { get { return Get<AckString>(2444); } set { SetObject(2444, value); } }

		// ENGINE_STRING app_name;
		public static AckString AppName { get { return Get<AckString>(2448); } set { SetObject(2448, value); } }

		// ENGINE_STRING level_name;
		public static AckString LevelName { get { return Get<AckString>(2452); } set { SetObject(2452, value); } }

		// ENGINE_STRING player_name;
		public static AckString PlayerName { get { return Get<AckString>(2456); } set { SetObject(2456, value); } }

		// ENGINE_STRING session_name;
		public static AckString SessionName { get { return Get<AckString>(2460); } set { SetObject(2460, value); } }

		// ENGINE_STRING server_name;
		public static AckString ServerName { get { return Get<AckString>(2464); } set { SetObject(2464, value); } }

		// ENGINE_STRING server_ip;
		public static AckString ServerIp { get { return Get<AckString>(2468); } set { SetObject(2468, value); } }

		// ENGINE_STRING work_dir;
		public static AckString WorkDir { get { return Get<AckString>(2472); } set { SetObject(2472, value); } }

		// ENGINE_STRING save_dir;
		public static AckString SaveDir { get { return Get<AckString>(2476); } set { SetObject(2476, value); } }

		// ENGINE_STRING exe_dir;
		public static AckString ExeDir { get { return Get<AckString>(2480); } set { SetObject(2480, value); } }

		// ENGINE_ENTITY player;
		public static Entity Player { get { return Get<Entity>(2484); } set { SetObject(2484, value); } }

		// ENGINE_STRING user_name;
		public static AckString UserName { get { return Get<AckString>(2488); } set { SetObject(2488, value); } }

		// ENGINE_ENTITY passable_ent;
		public static Entity PassableEnt { get { return Get<Entity>(2492); } set { SetObject(2492, value); } }

		// ENGINE_STRING path_name;
		public static AckString PathName { get { return Get<AckString>(2496); } set { SetObject(2496, value); } }

		// ENGINE_STRING command_str;
		public static AckString CommandStr { get { return Get<AckString>(2500); } set { SetObject(2500, value); } }

		// ENGINE_ENTITY level_ent;
		public static Entity LevelEnt { get { return Get<Entity>(2504); } set { SetObject(2504, value); } }

		// ENGINE_PANEL mouse_panel;

		// ENGINE_ void* render_d3dmaterial;
		public static IntPtr RenderD3dmaterial { get { return GetPtr(2516); } set { SetPtr(2516, value); } }

		// ENGINE_ void* render_d3dxeffect;
		public static IntPtr RenderD3dxeffect { get { return GetPtr(2520); } set { SetPtr(2520, value); } }

		// ENGINE_MATERIAL render_material;
		public static Material RenderMaterial { get { return Get<Material>(2524); } set { SetObject(2524, value); } }

		// ENGINE_BMAP render_target;
		public static Bitmap RenderTarget { get { return Get<Bitmap>(2528); } set { SetObject(2528, value); } }

		// ENGINE_BMAP render_stencil;
		public static Bitmap RenderStencil { get { return Get<Bitmap>(2532); } set { SetObject(2532, value); } }

		// ENGINE_ void* render_zbuffer;
		public static IntPtr RenderZbuffer { get { return GetPtr(2536); } set { SetPtr(2536, value); } }

		// ENGINE_BMAP video_overlay;
		public static Bitmap VideoOverlay { get { return Get<Bitmap>(2540); } set { SetObject(2540, value); } }

		// ENGINE_BMAP render_lightmap;
		public static Bitmap RenderLightmap { get { return Get<Bitmap>(2544); } set { SetObject(2544, value); } }

		// ENGINE_CONTACT hit;

		// ENGINE_ float* matTexture;
// ENGINE_ float* matTexture;

		// ENGINE_ float* matEffect;
// ENGINE_ float* matEffect;

		// ENGINE_ float* matView;
// ENGINE_ float* matView;

		// ENGINE_ float* matViewInv;
// ENGINE_ float* matViewInv;

		// ENGINE_ float* matProj;
// ENGINE_ float* matProj;

		// ENGINE_ float* matWorld;
// ENGINE_ float* matWorld;

		// ENGINE_ float* matViewProj;
// ENGINE_ float* matViewProj;

		// ENGINE_ float* matProjInv;
// ENGINE_ float* matProjInv;

		// void (*SendPacket)(long to,void *data,long size,long flags);

		// void (*ReceivePacket)(long from,void *data,long size);

		// long (*ScanMessage)(UINT message, WPARAM w_param, LPARAM l_param);

		// long (*GetObj)(char *name);

		// long (*GetFunc)(char *name);

		// long (*CallFunc)(long,long,long,long,long);

		// ENGINE_ BOOL isPointer;
// ENGINE_ BOOL isPointer;

		// ENGINE_ void *EngineFunctions;
// ENGINE_ void *EngineFunctions;

		// ENGINE_ void* pdi;
		public static IntPtr Pdi { get { return GetPtr(2672); } set { SetPtr(2672, value); } }

		// ENGINE_ void* pdimouse;
		public static IntPtr Pdimouse { get { return GetPtr(2676); } set { SetPtr(2676, value); } }

		// ENGINE_ void* pdikbd;
		public static IntPtr Pdikbd { get { return GetPtr(2680); } set { SetPtr(2680, value); } }

		// ENGINE_ void* pdijoy;
		public static IntPtr Pdijoy { get { return GetPtr(2684); } set { SetPtr(2684, value); } }

		// ENGINE_ void** pbody;
// ENGINE_ void** pbody;

		// ENGINE_ void* pvertexdecl;
		public static IntPtr Pvertexdecl { get { return GetPtr(2692); } set { SetPtr(2692, value); } }

		// ENGINE_ void* pds;
		public static IntPtr Pds { get { return GetPtr(2704); } set { SetPtr(2704, value); } }

		// ENGINE_ void* pdsb;
		public static IntPtr Pdsb { get { return GetPtr(2708); } set { SetPtr(2708, value); } }

		// ENGINE_ void* pd3d;
		public static IntPtr Pd3d { get { return GetPtr(2712); } set { SetPtr(2712, value); } }

		// ENGINE_ void* pd3ddev;
		public static IntPtr Pd3ddev { get { return GetPtr(2716); } set { SetPtr(2716, value); } }

		// ENGINE_ HWND hWnd;
// ENGINE_ HWND hWnd;

		// ENGINE_ void* pd3dcaps;
		public static IntPtr Pd3dcaps { get { return GetPtr(2724); } set { SetPtr(2724, value); } }

		// ENGINE_ long hInstance;
// ENGINE_ long hInstance;

		// ENGINE_ HWND hWndTarget;
// ENGINE_ HWND hWndTarget;

		// ENGINE_ RECT* pRectTarget;
// ENGINE_ RECT* pRectTarget;

		// ENGINE_ char** pPaths;
// ENGINE_ char** pPaths;

		// ENGINE_ void* pVars;
		public static IntPtr PVars { get { return GetPtr(2744); } set { SetPtr(2744, value); } }

		// ENGINE_ HWND hWndParent;
// ENGINE_ HWND hWndParent;

		// ENGINE_ void* pdsbs;
		public static IntPtr Pdsbs { get { return GetPtr(2764); } set { SetPtr(2764, value); } }

		// ENGINE_ float* mat_effect1;
// ENGINE_ float* mat_effect1;

		// ENGINE_ float* mat_effect2;
// ENGINE_ float* mat_effect2;

		// ENGINE_ float* mat_effect3;
// ENGINE_ float* mat_effect3;

		// ENGINE_ float* mat_effect4;
// ENGINE_ float* mat_effect4;

		// ENGINE_ float* mat_effect5;
// ENGINE_ float* mat_effect5;

		// ENGINE_ float* mat_effect6;
// ENGINE_ float* mat_effect6;

		// ENGINE_ float* mat_effect7;
// ENGINE_ float* mat_effect7;

		// ENGINE_ float* mat_effect8;
// ENGINE_ float* mat_effect8;
		internal static void InitializeEvents()
		{
			onBksp = (x) =>
			{
				if(OnBksp != null) OnBksp(null, new EngineEventArgs(x));
				return 0.0;
			};
			onEnter = (x) =>
			{
				if(OnEnter != null) OnEnter(null, new EngineEventArgs(x));
				return 0.0;
			};
			onEsc = (x) =>
			{
				if(OnEsc != null) OnEsc(null, new EngineEventArgs(x));
				return 0.0;
			};
			onAlt = (x) =>
			{
				if(OnAlt != null) OnAlt(null, new EngineEventArgs(x));
				return 0.0;
			};
			onCtrl = (x) =>
			{
				if(OnCtrl != null) OnCtrl(null, new EngineEventArgs(x));
				return 0.0;
			};
			onShiftl = (x) =>
			{
				if(OnShiftl != null) OnShiftl(null, new EngineEventArgs(x));
				return 0.0;
			};
			onShiftr = (x) =>
			{
				if(OnShiftr != null) OnShiftr(null, new EngineEventArgs(x));
				return 0.0;
			};
			onSpace = (x) =>
			{
				if(OnSpace != null) OnSpace(null, new EngineEventArgs(x));
				return 0.0;
			};
			onTab = (x) =>
			{
				if(OnTab != null) OnTab(null, new EngineEventArgs(x));
				return 0.0;
			};
			onF1 = (x) =>
			{
				if(OnF1 != null) OnF1(null, new EngineEventArgs(x));
				return 0.0;
			};
			onF2 = (x) =>
			{
				if(OnF2 != null) OnF2(null, new EngineEventArgs(x));
				return 0.0;
			};
			onF3 = (x) =>
			{
				if(OnF3 != null) OnF3(null, new EngineEventArgs(x));
				return 0.0;
			};
			onF4 = (x) =>
			{
				if(OnF4 != null) OnF4(null, new EngineEventArgs(x));
				return 0.0;
			};
			onF5 = (x) =>
			{
				if(OnF5 != null) OnF5(null, new EngineEventArgs(x));
				return 0.0;
			};
			onF6 = (x) =>
			{
				if(OnF6 != null) OnF6(null, new EngineEventArgs(x));
				return 0.0;
			};
			onF7 = (x) =>
			{
				if(OnF7 != null) OnF7(null, new EngineEventArgs(x));
				return 0.0;
			};
			onF8 = (x) =>
			{
				if(OnF8 != null) OnF8(null, new EngineEventArgs(x));
				return 0.0;
			};
			onF9 = (x) =>
			{
				if(OnF9 != null) OnF9(null, new EngineEventArgs(x));
				return 0.0;
			};
			onF10 = (x) =>
			{
				if(OnF10 != null) OnF10(null, new EngineEventArgs(x));
				return 0.0;
			};
			onF11 = (x) =>
			{
				if(OnF11 != null) OnF11(null, new EngineEventArgs(x));
				return 0.0;
			};
			onF12 = (x) =>
			{
				if(OnF12 != null) OnF12(null, new EngineEventArgs(x));
				return 0.0;
			};
			onA = (x) =>
			{
				if(OnA != null) OnA(null, new EngineEventArgs(x));
				return 0.0;
			};
			onB = (x) =>
			{
				if(OnB != null) OnB(null, new EngineEventArgs(x));
				return 0.0;
			};
			onC = (x) =>
			{
				if(OnC != null) OnC(null, new EngineEventArgs(x));
				return 0.0;
			};
			onD = (x) =>
			{
				if(OnD != null) OnD(null, new EngineEventArgs(x));
				return 0.0;
			};
			onE = (x) =>
			{
				if(OnE != null) OnE(null, new EngineEventArgs(x));
				return 0.0;
			};
			onF = (x) =>
			{
				if(OnF != null) OnF(null, new EngineEventArgs(x));
				return 0.0;
			};
			onG = (x) =>
			{
				if(OnG != null) OnG(null, new EngineEventArgs(x));
				return 0.0;
			};
			onH = (x) =>
			{
				if(OnH != null) OnH(null, new EngineEventArgs(x));
				return 0.0;
			};
			onI = (x) =>
			{
				if(OnI != null) OnI(null, new EngineEventArgs(x));
				return 0.0;
			};
			onJ = (x) =>
			{
				if(OnJ != null) OnJ(null, new EngineEventArgs(x));
				return 0.0;
			};
			onK = (x) =>
			{
				if(OnK != null) OnK(null, new EngineEventArgs(x));
				return 0.0;
			};
			onL = (x) =>
			{
				if(OnL != null) OnL(null, new EngineEventArgs(x));
				return 0.0;
			};
			onM = (x) =>
			{
				if(OnM != null) OnM(null, new EngineEventArgs(x));
				return 0.0;
			};
			onN = (x) =>
			{
				if(OnN != null) OnN(null, new EngineEventArgs(x));
				return 0.0;
			};
			onO = (x) =>
			{
				if(OnO != null) OnO(null, new EngineEventArgs(x));
				return 0.0;
			};
			onP = (x) =>
			{
				if(OnP != null) OnP(null, new EngineEventArgs(x));
				return 0.0;
			};
			onQ = (x) =>
			{
				if(OnQ != null) OnQ(null, new EngineEventArgs(x));
				return 0.0;
			};
			onR = (x) =>
			{
				if(OnR != null) OnR(null, new EngineEventArgs(x));
				return 0.0;
			};
			onS = (x) =>
			{
				if(OnS != null) OnS(null, new EngineEventArgs(x));
				return 0.0;
			};
			onT = (x) =>
			{
				if(OnT != null) OnT(null, new EngineEventArgs(x));
				return 0.0;
			};
			onU = (x) =>
			{
				if(OnU != null) OnU(null, new EngineEventArgs(x));
				return 0.0;
			};
			onV = (x) =>
			{
				if(OnV != null) OnV(null, new EngineEventArgs(x));
				return 0.0;
			};
			onW = (x) =>
			{
				if(OnW != null) OnW(null, new EngineEventArgs(x));
				return 0.0;
			};
			onX = (x) =>
			{
				if(OnX != null) OnX(null, new EngineEventArgs(x));
				return 0.0;
			};
			onY = (x) =>
			{
				if(OnY != null) OnY(null, new EngineEventArgs(x));
				return 0.0;
			};
			onZ = (x) =>
			{
				if(OnZ != null) OnZ(null, new EngineEventArgs(x));
				return 0.0;
			};
			onCuu = (x) =>
			{
				if(OnCuu != null) OnCuu(null, new EngineEventArgs(x));
				return 0.0;
			};
			onCud = (x) =>
			{
				if(OnCud != null) OnCud(null, new EngineEventArgs(x));
				return 0.0;
			};
			onCur = (x) =>
			{
				if(OnCur != null) OnCur(null, new EngineEventArgs(x));
				return 0.0;
			};
			onCul = (x) =>
			{
				if(OnCul != null) OnCul(null, new EngineEventArgs(x));
				return 0.0;
			};
			onPgup = (x) =>
			{
				if(OnPgup != null) OnPgup(null, new EngineEventArgs(x));
				return 0.0;
			};
			onPgdn = (x) =>
			{
				if(OnPgdn != null) OnPgdn(null, new EngineEventArgs(x));
				return 0.0;
			};
			onHome = (x) =>
			{
				if(OnHome != null) OnHome(null, new EngineEventArgs(x));
				return 0.0;
			};
			onEnd = (x) =>
			{
				if(OnEnd != null) OnEnd(null, new EngineEventArgs(x));
				return 0.0;
			};
			onIns = (x) =>
			{
				if(OnIns != null) OnIns(null, new EngineEventArgs(x));
				return 0.0;
			};
			onDel = (x) =>
			{
				if(OnDel != null) OnDel(null, new EngineEventArgs(x));
				return 0.0;
			};
			onCar = (x) =>
			{
				if(OnCar != null) OnCar(null, new EngineEventArgs(x));
				return 0.0;
			};
			onCal = (x) =>
			{
				if(OnCal != null) OnCal(null, new EngineEventArgs(x));
				return 0.0;
			};
			onSlash = (x) =>
			{
				if(OnSlash != null) OnSlash(null, new EngineEventArgs(x));
				return 0.0;
			};
			onEquals = (x) =>
			{
				if(OnEquals != null) OnEquals(null, new EngineEventArgs(x));
				return 0.0;
			};
			onPeriod = (x) =>
			{
				if(OnPeriod != null) OnPeriod(null, new EngineEventArgs(x));
				return 0.0;
			};
			onComma = (x) =>
			{
				if(OnComma != null) OnComma(null, new EngineEventArgs(x));
				return 0.0;
			};
			onBrackl = (x) =>
			{
				if(OnBrackl != null) OnBrackl(null, new EngineEventArgs(x));
				return 0.0;
			};
			onBrackr = (x) =>
			{
				if(OnBrackr != null) OnBrackr(null, new EngineEventArgs(x));
				return 0.0;
			};
			onSemic = (x) =>
			{
				if(OnSemic != null) OnSemic(null, new EngineEventArgs(x));
				return 0.0;
			};
			onBksl = (x) =>
			{
				if(OnBksl != null) OnBksl(null, new EngineEventArgs(x));
				return 0.0;
			};
			onApos = (x) =>
			{
				if(OnApos != null) OnApos(null, new EngineEventArgs(x));
				return 0.0;
			};
			onMinusc = (x) =>
			{
				if(OnMinusc != null) OnMinusc(null, new EngineEventArgs(x));
				return 0.0;
			};
			onGrave = (x) =>
			{
				if(OnGrave != null) OnGrave(null, new EngineEventArgs(x));
				return 0.0;
			};
			onCaps = (x) =>
			{
				if(OnCaps != null) OnCaps(null, new EngineEventArgs(x));
				return 0.0;
			};
			onScrlk = (x) =>
			{
				if(OnScrlk != null) OnScrlk(null, new EngineEventArgs(x));
				return 0.0;
			};
			onPlus = (x) =>
			{
				if(OnPlus != null) OnPlus(null, new EngineEventArgs(x));
				return 0.0;
			};
			onSz = (x) =>
			{
				if(OnSz != null) OnSz(null, new EngineEventArgs(x));
				return 0.0;
			};
			onAe = (x) =>
			{
				if(OnAe != null) OnAe(null, new EngineEventArgs(x));
				return 0.0;
			};
			onUe = (x) =>
			{
				if(OnUe != null) OnUe(null, new EngineEventArgs(x));
				return 0.0;
			};
			onOe = (x) =>
			{
				if(OnOe != null) OnOe(null, new EngineEventArgs(x));
				return 0.0;
			};
			on1 = (x) =>
			{
				if(On1 != null) On1(null, new EngineEventArgs(x));
				return 0.0;
			};
			on2 = (x) =>
			{
				if(On2 != null) On2(null, new EngineEventArgs(x));
				return 0.0;
			};
			on3 = (x) =>
			{
				if(On3 != null) On3(null, new EngineEventArgs(x));
				return 0.0;
			};
			on4 = (x) =>
			{
				if(On4 != null) On4(null, new EngineEventArgs(x));
				return 0.0;
			};
			on5 = (x) =>
			{
				if(On5 != null) On5(null, new EngineEventArgs(x));
				return 0.0;
			};
			on6 = (x) =>
			{
				if(On6 != null) On6(null, new EngineEventArgs(x));
				return 0.0;
			};
			on7 = (x) =>
			{
				if(On7 != null) On7(null, new EngineEventArgs(x));
				return 0.0;
			};
			on8 = (x) =>
			{
				if(On8 != null) On8(null, new EngineEventArgs(x));
				return 0.0;
			};
			on9 = (x) =>
			{
				if(On9 != null) On9(null, new EngineEventArgs(x));
				return 0.0;
			};
			on0 = (x) =>
			{
				if(On0 != null) On0(null, new EngineEventArgs(x));
				return 0.0;
			};
			onPause = (x) =>
			{
				if(OnPause != null) OnPause(null, new EngineEventArgs(x));
				return 0.0;
			};
			onMouseLeft = (x) =>
			{
				if(OnMouseLeft != null) OnMouseLeft(null, new EngineEventArgs(x));
				return 0.0;
			};
			onMouseRight = (x) =>
			{
				if(OnMouseRight != null) OnMouseRight(null, new EngineEventArgs(x));
				return 0.0;
			};
			onMouseMiddle = (x) =>
			{
				if(OnMouseMiddle != null) OnMouseMiddle(null, new EngineEventArgs(x));
				return 0.0;
			};
			onJoy1 = (x) =>
			{
				if(OnJoy1 != null) OnJoy1(null, new EngineEventArgs(x));
				return 0.0;
			};
			onJoy2 = (x) =>
			{
				if(OnJoy2 != null) OnJoy2(null, new EngineEventArgs(x));
				return 0.0;
			};
			onJoy3 = (x) =>
			{
				if(OnJoy3 != null) OnJoy3(null, new EngineEventArgs(x));
				return 0.0;
			};
			onJoy4 = (x) =>
			{
				if(OnJoy4 != null) OnJoy4(null, new EngineEventArgs(x));
				return 0.0;
			};
			onJoy5 = (x) =>
			{
				if(OnJoy5 != null) OnJoy5(null, new EngineEventArgs(x));
				return 0.0;
			};
			onJoy6 = (x) =>
			{
				if(OnJoy6 != null) OnJoy6(null, new EngineEventArgs(x));
				return 0.0;
			};
			onJoy7 = (x) =>
			{
				if(OnJoy7 != null) OnJoy7(null, new EngineEventArgs(x));
				return 0.0;
			};
			onJoy8 = (x) =>
			{
				if(OnJoy8 != null) OnJoy8(null, new EngineEventArgs(x));
				return 0.0;
			};
			onJoy9 = (x) =>
			{
				if(OnJoy9 != null) OnJoy9(null, new EngineEventArgs(x));
				return 0.0;
			};
			onJoy10 = (x) =>
			{
				if(OnJoy10 != null) OnJoy10(null, new EngineEventArgs(x));
				return 0.0;
			};
			onJoy11 = (x) =>
			{
				if(OnJoy11 != null) OnJoy11(null, new EngineEventArgs(x));
				return 0.0;
			};
			onJoy12 = (x) =>
			{
				if(OnJoy12 != null) OnJoy12(null, new EngineEventArgs(x));
				return 0.0;
			};
			onJoy21 = (x) =>
			{
				if(OnJoy21 != null) OnJoy21(null, new EngineEventArgs(x));
				return 0.0;
			};
			onJoy22 = (x) =>
			{
				if(OnJoy22 != null) OnJoy22(null, new EngineEventArgs(x));
				return 0.0;
			};
			onJoy23 = (x) =>
			{
				if(OnJoy23 != null) OnJoy23(null, new EngineEventArgs(x));
				return 0.0;
			};
			onJoy24 = (x) =>
			{
				if(OnJoy24 != null) OnJoy24(null, new EngineEventArgs(x));
				return 0.0;
			};
			onJoy25 = (x) =>
			{
				if(OnJoy25 != null) OnJoy25(null, new EngineEventArgs(x));
				return 0.0;
			};
			onJoy26 = (x) =>
			{
				if(OnJoy26 != null) OnJoy26(null, new EngineEventArgs(x));
				return 0.0;
			};
			onJoy27 = (x) =>
			{
				if(OnJoy27 != null) OnJoy27(null, new EngineEventArgs(x));
				return 0.0;
			};
			onJoy28 = (x) =>
			{
				if(OnJoy28 != null) OnJoy28(null, new EngineEventArgs(x));
				return 0.0;
			};
			onJoy29 = (x) =>
			{
				if(OnJoy29 != null) OnJoy29(null, new EngineEventArgs(x));
				return 0.0;
			};
			onJoy210 = (x) =>
			{
				if(OnJoy210 != null) OnJoy210(null, new EngineEventArgs(x));
				return 0.0;
			};
			onJoy211 = (x) =>
			{
				if(OnJoy211 != null) OnJoy211(null, new EngineEventArgs(x));
				return 0.0;
			};
			onJoy212 = (x) =>
			{
				if(OnJoy212 != null) OnJoy212(null, new EngineEventArgs(x));
				return 0.0;
			};
			onAnykey = (x) =>
			{
				if(OnAnykey != null) OnAnykey(null, new EngineEventArgs(x));
				return 0.0;
			};
			onClick = (x) =>
			{
				if(OnClick != null) OnClick(null, new EngineEventArgs(x));
				return 0.0;
			};
			onMouseStop = (x) =>
			{
				if(OnMouseStop != null) OnMouseStop(null, new EngineEventArgs(x));
				return 0.0;
			};
			onClose = (x) =>
			{
				if(OnClose != null) OnClose(null, new EngineEventArgs(x));
				return 0.0;
			};
			onLoad = (x) =>
			{
				if(OnLoad != null) OnLoad(null, new EngineEventArgs(x));
				return 0.0;
			};
			onLevel = (x) =>
			{
				if(OnLevel != null) OnLevel(null, new EngineEventArgs(x));
				return 0.0;
			};
			onServer = (x) =>
			{
				if(OnServer != null) OnServer(null, new EngineEventArgs(x));
				return 0.0;
			};
			onClient = (x) =>
			{
				if(OnClient != null) OnClient(null, new EngineEventArgs(x));
				return 0.0;
			};
			onD3dLost = (x) =>
			{
				if(OnD3dLost != null) OnD3dLost(null, new EngineEventArgs(x));
				return 0.0;
			};
			onD3dReset = (x) =>
			{
				if(OnD3dReset != null) OnD3dReset(null, new EngineEventArgs(x));
				return 0.0;
			};
			renderSky = (x) =>
			{
				if(RenderSky != null) RenderSky(null, new EngineEventArgs(x));
				return 0.0;
			};
			renderWorld = (x) =>
			{
				if(RenderWorld != null) RenderWorld(null, new EngineEventArgs(x));
				return 0.0;
			};
			renderEntities = (x) =>
			{
				if(RenderEntities != null) RenderEntities(null, new EngineEventArgs(x));
				return 0.0;
			};
			renderSolid = (x) =>
			{
				if(RenderSolid != null) RenderSolid(null, new EngineEventArgs(x));
				return 0.0;
			};
			onExit = (x) =>
			{
				if(OnExit != null) OnExit(null, new EngineEventArgs(x));
				return 0.0;
			};
			onFrame = (x) =>
			{
				if(OnFrame != null) OnFrame(null, new EngineEventArgs(x));
				return 0.0;
			};
			onMaximize = (x) =>
			{
				if(OnMaximize != null) OnMaximize(null, new EngineEventArgs(x));
				return 0.0;
			};
			onMinimize = (x) =>
			{
				if(OnMinimize != null) OnMinimize(null, new EngineEventArgs(x));
				return 0.0;
			};
			onResize = (x) =>
			{
				if(OnResize != null) OnResize(null, new EngineEventArgs(x));
				return 0.0;
			};
			onLevelLoad = (x) =>
			{
				if(OnLevelLoad != null) OnLevelLoad(null, new EngineEventArgs(x));
				return 0.0;
			};
			onEntRemove = (x) =>
			{
				if(OnEntRemove != null) OnEntRemove(null, new EngineEventArgs(x));
				return 0.0;
			};
			renderLayer = (x) =>
			{
				if(RenderLayer != null) RenderLayer(null, new EngineEventArgs(x));
				return 0.0;
			};
			SetEvent(1736, onBksp);
			SetEvent(1740, onEnter);
			SetEvent(1744, onEsc);
			SetEvent(1748, onAlt);
			SetEvent(1752, onCtrl);
			SetEvent(1756, onShiftl);
			SetEvent(1760, onShiftr);
			SetEvent(1764, onSpace);
			SetEvent(1768, onTab);
			SetEvent(1772, onF1);
			SetEvent(1776, onF2);
			SetEvent(1780, onF3);
			SetEvent(1784, onF4);
			SetEvent(1788, onF5);
			SetEvent(1792, onF6);
			SetEvent(1796, onF7);
			SetEvent(1800, onF8);
			SetEvent(1804, onF9);
			SetEvent(1808, onF10);
			SetEvent(1812, onF11);
			SetEvent(1816, onF12);
			SetEvent(1820, onA);
			SetEvent(1824, onB);
			SetEvent(1828, onC);
			SetEvent(1832, onD);
			SetEvent(1836, onE);
			SetEvent(1840, onF);
			SetEvent(1844, onG);
			SetEvent(1848, onH);
			SetEvent(1852, onI);
			SetEvent(1856, onJ);
			SetEvent(1860, onK);
			SetEvent(1864, onL);
			SetEvent(1868, onM);
			SetEvent(1872, onN);
			SetEvent(1876, onO);
			SetEvent(1880, onP);
			SetEvent(1884, onQ);
			SetEvent(1888, onR);
			SetEvent(1892, onS);
			SetEvent(1896, onT);
			SetEvent(1900, onU);
			SetEvent(1904, onV);
			SetEvent(1908, onW);
			SetEvent(1912, onX);
			SetEvent(1916, onY);
			SetEvent(1920, onZ);
			SetEvent(1924, onCuu);
			SetEvent(1928, onCud);
			SetEvent(1932, onCur);
			SetEvent(1936, onCul);
			SetEvent(1940, onPgup);
			SetEvent(1944, onPgdn);
			SetEvent(1948, onHome);
			SetEvent(1952, onEnd);
			SetEvent(1956, onIns);
			SetEvent(1960, onDel);
			SetEvent(1964, onCar);
			SetEvent(1968, onCal);
			SetEvent(1972, onSlash);
			SetEvent(1976, onEquals);
			SetEvent(1980, onPeriod);
			SetEvent(1984, onComma);
			SetEvent(1988, onBrackl);
			SetEvent(1992, onBrackr);
			SetEvent(1996, onSemic);
			SetEvent(2000, onBksl);
			SetEvent(2004, onApos);
			SetEvent(2008, onMinusc);
			SetEvent(2012, onGrave);
			SetEvent(2016, onCaps);
			SetEvent(2020, onScrlk);
			SetEvent(2024, onPlus);
			SetEvent(2028, onSz);
			SetEvent(2032, onAe);
			SetEvent(2036, onUe);
			SetEvent(2040, onOe);
			SetEvent(2044, on1);
			SetEvent(2048, on2);
			SetEvent(2052, on3);
			SetEvent(2056, on4);
			SetEvent(2060, on5);
			SetEvent(2064, on6);
			SetEvent(2068, on7);
			SetEvent(2072, on8);
			SetEvent(2076, on9);
			SetEvent(2080, on0);
			SetEvent(2084, onPause);
			SetEvent(2088, onMouseLeft);
			SetEvent(2092, onMouseRight);
			SetEvent(2096, onMouseMiddle);
			SetEvent(2100, onJoy1);
			SetEvent(2104, onJoy2);
			SetEvent(2108, onJoy3);
			SetEvent(2112, onJoy4);
			SetEvent(2116, onJoy5);
			SetEvent(2120, onJoy6);
			SetEvent(2124, onJoy7);
			SetEvent(2128, onJoy8);
			SetEvent(2132, onJoy9);
			SetEvent(2136, onJoy10);
			SetEvent(2140, onJoy11);
			SetEvent(2144, onJoy12);
			SetEvent(2148, onJoy21);
			SetEvent(2152, onJoy22);
			SetEvent(2156, onJoy23);
			SetEvent(2160, onJoy24);
			SetEvent(2164, onJoy25);
			SetEvent(2168, onJoy26);
			SetEvent(2172, onJoy27);
			SetEvent(2176, onJoy28);
			SetEvent(2180, onJoy29);
			SetEvent(2184, onJoy210);
			SetEvent(2188, onJoy211);
			SetEvent(2192, onJoy212);
			SetEvent(2196, onAnykey);
			SetEvent(2200, onClick);
			SetEvent(2204, onMouseStop);
			SetEvent(2208, onClose);
			SetEvent(2212, onLoad);
			SetEvent(2216, onLevel);
			SetEvent(2220, onServer);
			SetEvent(2224, onClient);
			SetEvent(2228, onD3dLost);
			SetEvent(2232, onD3dReset);
			SetEvent(2236, renderSky);
			SetEvent(2240, renderWorld);
			SetEvent(2244, renderEntities);
			SetEvent(2248, renderSolid);
			SetEvent(2252, onExit);
			SetEvent(2256, onFrame);
			SetEvent(2264, onMaximize);
			SetEvent(2268, onMinimize);
			SetEvent(2272, onResize);
			SetEvent(2276, onLevelLoad);
			SetEvent(2280, onEntRemove);
			SetEvent(2284, renderLayer);
		}
	}
}
