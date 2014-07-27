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

		// ENGINE_VECTOR joy_raw;

		// ENGINE_VECTOR joy_rot;

		// ENGINE_VAR joy_hat;
		public static ackvar JoyHat { get { return GetVar(280); } set { SetVar(280, value); } }

		// ENGINE_VECTOR joy2_raw;

		// ENGINE_VECTOR joy2_rot;

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

		// ENGINE_VECTOR mouse_pos;

		// ENGINE_VECTOR mouse_spot;

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

		// ENGINE_VECTOR mouse_cursor;

		// ENGINE_VECTOR mouse_pos3d;

		// ENGINE_VECTOR mouse_dir3d;

		// ENGINE_VAR enable_key;
		public static ackvar EnableKey { get { return GetVar(392); } set { SetVar(392, value); } }

		// ENGINE_VAR key_sense;
		public static ackvar KeySense { get { return GetVar(396); } set { SetVar(396, value); } }

		// ENGINE_VECTOR key_force;

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

		// ENGINE_COLOR screen_color;

		// ENGINE_VAR window_focus;
		public static ackvar WindowFocus { get { return GetVar(456); } set { SetVar(456, value); } }

		// ENGINE_VAR video_gamma;
		public static ackvar VideoGamma { get { return GetVar(460); } set { SetVar(460, value); } }

		// ENGINE_VECTOR window_pos;

		// ENGINE_VAR d3d_antialias;
		public static ackvar D3dAntialias { get { return GetVar(468); } set { SetVar(468, value); } }

		// ENGINE_VAR mip_levels;
		public static ackvar MipLevels { get { return GetVar(472); } set { SetVar(472, value); } }

		// ENGINE_COLOR ambient_color;

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

		// ENGINE_VECTOR d3d_pointlightfalloff;

		// ENGINE_VECTOR d3d_spotlightfalloff;

		// ENGINE_VECTOR d3d_spotlightcone;

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

		// ENGINE_VAR max_bones;
		public static ackvar MaxBones { get { return GetVar(720); } set { SetVar(720, value); } }

		// ENGINE_VAR sky_blend;
		public static ackvar SkyBlend { get { return GetVar(724); } set { SetVar(724, value); } }

		// ENGINE_VECTOR sky_speed;

		// ENGINE_VECTOR cloud_speed;

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

		// ENGINE_ANGLE sun_angle;

		// ENGINE_VECTOR sun_pos;

		// ENGINE_VAR preload_mode;
		public static ackvar PreloadMode { get { return GetVar(780); } set { SetVar(780, value); } }

		// ENGINE_VAR fog_color;
		public static ackvar FogColor { get { return GetVar(784); } set { SetVar(784, value); } }

		// ENGINE_COLOR d3d_fogcolor1;

		// ENGINE_COLOR d3d_fogcolor2;

		// ENGINE_COLOR d3d_fogcolor3;

		// ENGINE_COLOR d3d_fogcolor4;

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
		public static ackvar Reserved63 { get { return GetVar(960); } set { SetVar(960, value); } }

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
		public static ackvar Reserved64 { get { return GetVar(1000); } set { SetVar(1000, value); } }

		// ENGINE_VECTOR hull_fatmin;

		// ENGINE_VECTOR hull_fatmax;

		// ENGINE_VECTOR hull_narrowmin;

		// ENGINE_VECTOR hull_narrowmax;

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

		// ENGINE_VECTOR bounce;

		// ENGINE_VECTOR target;

		// ENGINE_VECTOR vglide;

		// ENGINE_VAR on_passable;
		public static ackvar OnPassable { get { return GetVar(1060); } set { SetVar(1060, value); } }

		// ENGINE_VAR in_passable;
		public static ackvar InPassable { get { return GetVar(1064); } set { SetVar(1064, value); } }

		// ENGINE_VAR in_solid;
		public static ackvar InSolid { get { return GetVar(1068); } set { SetVar(1068, value); } }

		// ENGINE_VAR tex_light;
		public static ackvar TexLight { get { return GetVar(1072); } set { SetVar(1072, value); } }

		// ENGINE_COLOR tex_color;

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
		public static EngineEventDelegate OnBksp { get { return onBksp; } set { onBksp = value; SetEvent(1736, onBksp); } }

		// ENGINE_EVENT on_enter;
		private static EngineEventDelegate onEnter;
		public static EngineEventDelegate OnEnter { get { return onEnter; } set { onEnter = value; SetEvent(1740, onEnter); } }

		// ENGINE_EVENT on_esc;
		private static EngineEventDelegate onEsc;
		public static EngineEventDelegate OnEsc { get { return onEsc; } set { onEsc = value; SetEvent(1744, onEsc); } }

		// ENGINE_EVENT on_alt;
		private static EngineEventDelegate onAlt;
		public static EngineEventDelegate OnAlt { get { return onAlt; } set { onAlt = value; SetEvent(1748, onAlt); } }

		// ENGINE_EVENT on_ctrl;
		private static EngineEventDelegate onCtrl;
		public static EngineEventDelegate OnCtrl { get { return onCtrl; } set { onCtrl = value; SetEvent(1752, onCtrl); } }

		// ENGINE_EVENT on_shiftl;
		private static EngineEventDelegate onShiftl;
		public static EngineEventDelegate OnShiftl { get { return onShiftl; } set { onShiftl = value; SetEvent(1756, onShiftl); } }

		// ENGINE_EVENT on_shiftr;
		private static EngineEventDelegate onShiftr;
		public static EngineEventDelegate OnShiftr { get { return onShiftr; } set { onShiftr = value; SetEvent(1760, onShiftr); } }

		// ENGINE_EVENT on_space;
		private static EngineEventDelegate onSpace;
		public static EngineEventDelegate OnSpace { get { return onSpace; } set { onSpace = value; SetEvent(1764, onSpace); } }

		// ENGINE_EVENT on_tab;
		private static EngineEventDelegate onTab;
		public static EngineEventDelegate OnTab { get { return onTab; } set { onTab = value; SetEvent(1768, onTab); } }

		// ENGINE_EVENT on_f1;
		private static EngineEventDelegate onF1;
		public static EngineEventDelegate OnF1 { get { return onF1; } set { onF1 = value; SetEvent(1772, onF1); } }

		// ENGINE_EVENT on_f2;
		private static EngineEventDelegate onF2;
		public static EngineEventDelegate OnF2 { get { return onF2; } set { onF2 = value; SetEvent(1776, onF2); } }

		// ENGINE_EVENT on_f3;
		private static EngineEventDelegate onF3;
		public static EngineEventDelegate OnF3 { get { return onF3; } set { onF3 = value; SetEvent(1780, onF3); } }

		// ENGINE_EVENT on_f4;
		private static EngineEventDelegate onF4;
		public static EngineEventDelegate OnF4 { get { return onF4; } set { onF4 = value; SetEvent(1784, onF4); } }

		// ENGINE_EVENT on_f5;
		private static EngineEventDelegate onF5;
		public static EngineEventDelegate OnF5 { get { return onF5; } set { onF5 = value; SetEvent(1788, onF5); } }

		// ENGINE_EVENT on_f6;
		private static EngineEventDelegate onF6;
		public static EngineEventDelegate OnF6 { get { return onF6; } set { onF6 = value; SetEvent(1792, onF6); } }

		// ENGINE_EVENT on_f7;
		private static EngineEventDelegate onF7;
		public static EngineEventDelegate OnF7 { get { return onF7; } set { onF7 = value; SetEvent(1796, onF7); } }

		// ENGINE_EVENT on_f8;
		private static EngineEventDelegate onF8;
		public static EngineEventDelegate OnF8 { get { return onF8; } set { onF8 = value; SetEvent(1800, onF8); } }

		// ENGINE_EVENT on_f9;
		private static EngineEventDelegate onF9;
		public static EngineEventDelegate OnF9 { get { return onF9; } set { onF9 = value; SetEvent(1804, onF9); } }

		// ENGINE_EVENT on_f10;
		private static EngineEventDelegate onF10;
		public static EngineEventDelegate OnF10 { get { return onF10; } set { onF10 = value; SetEvent(1808, onF10); } }

		// ENGINE_EVENT on_f11;
		private static EngineEventDelegate onF11;
		public static EngineEventDelegate OnF11 { get { return onF11; } set { onF11 = value; SetEvent(1812, onF11); } }

		// ENGINE_EVENT on_f12;
		private static EngineEventDelegate onF12;
		public static EngineEventDelegate OnF12 { get { return onF12; } set { onF12 = value; SetEvent(1816, onF12); } }

		// ENGINE_EVENT on_a;
		private static EngineEventDelegate onA;
		public static EngineEventDelegate OnA { get { return onA; } set { onA = value; SetEvent(1820, onA); } }

		// ENGINE_EVENT on_b;
		private static EngineEventDelegate onB;
		public static EngineEventDelegate OnB { get { return onB; } set { onB = value; SetEvent(1824, onB); } }

		// ENGINE_EVENT on_c;
		private static EngineEventDelegate onC;
		public static EngineEventDelegate OnC { get { return onC; } set { onC = value; SetEvent(1828, onC); } }

		// ENGINE_EVENT on_d;
		private static EngineEventDelegate onD;
		public static EngineEventDelegate OnD { get { return onD; } set { onD = value; SetEvent(1832, onD); } }

		// ENGINE_EVENT on_e;
		private static EngineEventDelegate onE;
		public static EngineEventDelegate OnE { get { return onE; } set { onE = value; SetEvent(1836, onE); } }

		// ENGINE_EVENT on_f;
		private static EngineEventDelegate onF;
		public static EngineEventDelegate OnF { get { return onF; } set { onF = value; SetEvent(1840, onF); } }

		// ENGINE_EVENT on_g;
		private static EngineEventDelegate onG;
		public static EngineEventDelegate OnG { get { return onG; } set { onG = value; SetEvent(1844, onG); } }

		// ENGINE_EVENT on_h;
		private static EngineEventDelegate onH;
		public static EngineEventDelegate OnH { get { return onH; } set { onH = value; SetEvent(1848, onH); } }

		// ENGINE_EVENT on_i;
		private static EngineEventDelegate onI;
		public static EngineEventDelegate OnI { get { return onI; } set { onI = value; SetEvent(1852, onI); } }

		// ENGINE_EVENT on_j;
		private static EngineEventDelegate onJ;
		public static EngineEventDelegate OnJ { get { return onJ; } set { onJ = value; SetEvent(1856, onJ); } }

		// ENGINE_EVENT on_k;
		private static EngineEventDelegate onK;
		public static EngineEventDelegate OnK { get { return onK; } set { onK = value; SetEvent(1860, onK); } }

		// ENGINE_EVENT on_l;
		private static EngineEventDelegate onL;
		public static EngineEventDelegate OnL { get { return onL; } set { onL = value; SetEvent(1864, onL); } }

		// ENGINE_EVENT on_m;
		private static EngineEventDelegate onM;
		public static EngineEventDelegate OnM { get { return onM; } set { onM = value; SetEvent(1868, onM); } }

		// ENGINE_EVENT on_n;
		private static EngineEventDelegate onN;
		public static EngineEventDelegate OnN { get { return onN; } set { onN = value; SetEvent(1872, onN); } }

		// ENGINE_EVENT on_o;
		private static EngineEventDelegate onO;
		public static EngineEventDelegate OnO { get { return onO; } set { onO = value; SetEvent(1876, onO); } }

		// ENGINE_EVENT on_p;
		private static EngineEventDelegate onP;
		public static EngineEventDelegate OnP { get { return onP; } set { onP = value; SetEvent(1880, onP); } }

		// ENGINE_EVENT on_q;
		private static EngineEventDelegate onQ;
		public static EngineEventDelegate OnQ { get { return onQ; } set { onQ = value; SetEvent(1884, onQ); } }

		// ENGINE_EVENT on_r;
		private static EngineEventDelegate onR;
		public static EngineEventDelegate OnR { get { return onR; } set { onR = value; SetEvent(1888, onR); } }

		// ENGINE_EVENT on_s;
		private static EngineEventDelegate onS;
		public static EngineEventDelegate OnS { get { return onS; } set { onS = value; SetEvent(1892, onS); } }

		// ENGINE_EVENT on_t;
		private static EngineEventDelegate onT;
		public static EngineEventDelegate OnT { get { return onT; } set { onT = value; SetEvent(1896, onT); } }

		// ENGINE_EVENT on_u;
		private static EngineEventDelegate onU;
		public static EngineEventDelegate OnU { get { return onU; } set { onU = value; SetEvent(1900, onU); } }

		// ENGINE_EVENT on_v;
		private static EngineEventDelegate onV;
		public static EngineEventDelegate OnV { get { return onV; } set { onV = value; SetEvent(1904, onV); } }

		// ENGINE_EVENT on_w;
		private static EngineEventDelegate onW;
		public static EngineEventDelegate OnW { get { return onW; } set { onW = value; SetEvent(1908, onW); } }

		// ENGINE_EVENT on_x;
		private static EngineEventDelegate onX;
		public static EngineEventDelegate OnX { get { return onX; } set { onX = value; SetEvent(1912, onX); } }

		// ENGINE_EVENT on_y;
		private static EngineEventDelegate onY;
		public static EngineEventDelegate OnY { get { return onY; } set { onY = value; SetEvent(1916, onY); } }

		// ENGINE_EVENT on_z;
		private static EngineEventDelegate onZ;
		public static EngineEventDelegate OnZ { get { return onZ; } set { onZ = value; SetEvent(1920, onZ); } }

		// ENGINE_EVENT on_cuu;
		private static EngineEventDelegate onCuu;
		public static EngineEventDelegate OnCuu { get { return onCuu; } set { onCuu = value; SetEvent(1924, onCuu); } }

		// ENGINE_EVENT on_cud;
		private static EngineEventDelegate onCud;
		public static EngineEventDelegate OnCud { get { return onCud; } set { onCud = value; SetEvent(1928, onCud); } }

		// ENGINE_EVENT on_cur;
		private static EngineEventDelegate onCur;
		public static EngineEventDelegate OnCur { get { return onCur; } set { onCur = value; SetEvent(1932, onCur); } }

		// ENGINE_EVENT on_cul;
		private static EngineEventDelegate onCul;
		public static EngineEventDelegate OnCul { get { return onCul; } set { onCul = value; SetEvent(1936, onCul); } }

		// ENGINE_EVENT on_pgup;
		private static EngineEventDelegate onPgup;
		public static EngineEventDelegate OnPgup { get { return onPgup; } set { onPgup = value; SetEvent(1940, onPgup); } }

		// ENGINE_EVENT on_pgdn;
		private static EngineEventDelegate onPgdn;
		public static EngineEventDelegate OnPgdn { get { return onPgdn; } set { onPgdn = value; SetEvent(1944, onPgdn); } }

		// ENGINE_EVENT on_home;
		private static EngineEventDelegate onHome;
		public static EngineEventDelegate OnHome { get { return onHome; } set { onHome = value; SetEvent(1948, onHome); } }

		// ENGINE_EVENT on_end;
		private static EngineEventDelegate onEnd;
		public static EngineEventDelegate OnEnd { get { return onEnd; } set { onEnd = value; SetEvent(1952, onEnd); } }

		// ENGINE_EVENT on_ins;
		private static EngineEventDelegate onIns;
		public static EngineEventDelegate OnIns { get { return onIns; } set { onIns = value; SetEvent(1956, onIns); } }

		// ENGINE_EVENT on_del;
		private static EngineEventDelegate onDel;
		public static EngineEventDelegate OnDel { get { return onDel; } set { onDel = value; SetEvent(1960, onDel); } }

		// ENGINE_EVENT on_car;
		private static EngineEventDelegate onCar;
		public static EngineEventDelegate OnCar { get { return onCar; } set { onCar = value; SetEvent(1964, onCar); } }

		// ENGINE_EVENT on_cal;
		private static EngineEventDelegate onCal;
		public static EngineEventDelegate OnCal { get { return onCal; } set { onCal = value; SetEvent(1968, onCal); } }

		// ENGINE_EVENT on_slash;
		private static EngineEventDelegate onSlash;
		public static EngineEventDelegate OnSlash { get { return onSlash; } set { onSlash = value; SetEvent(1972, onSlash); } }

		// ENGINE_EVENT on_equals;
		private static EngineEventDelegate onEquals;
		public static EngineEventDelegate OnEquals { get { return onEquals; } set { onEquals = value; SetEvent(1976, onEquals); } }

		// ENGINE_EVENT on_period;
		private static EngineEventDelegate onPeriod;
		public static EngineEventDelegate OnPeriod { get { return onPeriod; } set { onPeriod = value; SetEvent(1980, onPeriod); } }

		// ENGINE_EVENT on_comma;
		private static EngineEventDelegate onComma;
		public static EngineEventDelegate OnComma { get { return onComma; } set { onComma = value; SetEvent(1984, onComma); } }

		// ENGINE_EVENT on_brackl;
		private static EngineEventDelegate onBrackl;
		public static EngineEventDelegate OnBrackl { get { return onBrackl; } set { onBrackl = value; SetEvent(1988, onBrackl); } }

		// ENGINE_EVENT on_brackr;
		private static EngineEventDelegate onBrackr;
		public static EngineEventDelegate OnBrackr { get { return onBrackr; } set { onBrackr = value; SetEvent(1992, onBrackr); } }

		// ENGINE_EVENT on_semic;
		private static EngineEventDelegate onSemic;
		public static EngineEventDelegate OnSemic { get { return onSemic; } set { onSemic = value; SetEvent(1996, onSemic); } }

		// ENGINE_EVENT on_bksl;
		private static EngineEventDelegate onBksl;
		public static EngineEventDelegate OnBksl { get { return onBksl; } set { onBksl = value; SetEvent(2000, onBksl); } }

		// ENGINE_EVENT on_apos;
		private static EngineEventDelegate onApos;
		public static EngineEventDelegate OnApos { get { return onApos; } set { onApos = value; SetEvent(2004, onApos); } }

		// ENGINE_EVENT on_minusc;
		private static EngineEventDelegate onMinusc;
		public static EngineEventDelegate OnMinusc { get { return onMinusc; } set { onMinusc = value; SetEvent(2008, onMinusc); } }

		// ENGINE_EVENT on_grave;
		private static EngineEventDelegate onGrave;
		public static EngineEventDelegate OnGrave { get { return onGrave; } set { onGrave = value; SetEvent(2012, onGrave); } }

		// ENGINE_EVENT on_caps;
		private static EngineEventDelegate onCaps;
		public static EngineEventDelegate OnCaps { get { return onCaps; } set { onCaps = value; SetEvent(2016, onCaps); } }

		// ENGINE_EVENT on_scrlk;
		private static EngineEventDelegate onScrlk;
		public static EngineEventDelegate OnScrlk { get { return onScrlk; } set { onScrlk = value; SetEvent(2020, onScrlk); } }

		// ENGINE_EVENT on_plus;
		private static EngineEventDelegate onPlus;
		public static EngineEventDelegate OnPlus { get { return onPlus; } set { onPlus = value; SetEvent(2024, onPlus); } }

		// ENGINE_EVENT on_sz;
		private static EngineEventDelegate onSz;
		public static EngineEventDelegate OnSz { get { return onSz; } set { onSz = value; SetEvent(2028, onSz); } }

		// ENGINE_EVENT on_ae;
		private static EngineEventDelegate onAe;
		public static EngineEventDelegate OnAe { get { return onAe; } set { onAe = value; SetEvent(2032, onAe); } }

		// ENGINE_EVENT on_ue;
		private static EngineEventDelegate onUe;
		public static EngineEventDelegate OnUe { get { return onUe; } set { onUe = value; SetEvent(2036, onUe); } }

		// ENGINE_EVENT on_oe;
		private static EngineEventDelegate onOe;
		public static EngineEventDelegate OnOe { get { return onOe; } set { onOe = value; SetEvent(2040, onOe); } }

		// ENGINE_EVENT on_1;
		private static EngineEventDelegate on1;
		public static EngineEventDelegate On1 { get { return on1; } set { on1 = value; SetEvent(2044, on1); } }

		// ENGINE_EVENT on_2;
		private static EngineEventDelegate on2;
		public static EngineEventDelegate On2 { get { return on2; } set { on2 = value; SetEvent(2048, on2); } }

		// ENGINE_EVENT on_3;
		private static EngineEventDelegate on3;
		public static EngineEventDelegate On3 { get { return on3; } set { on3 = value; SetEvent(2052, on3); } }

		// ENGINE_EVENT on_4;
		private static EngineEventDelegate on4;
		public static EngineEventDelegate On4 { get { return on4; } set { on4 = value; SetEvent(2056, on4); } }

		// ENGINE_EVENT on_5;
		private static EngineEventDelegate on5;
		public static EngineEventDelegate On5 { get { return on5; } set { on5 = value; SetEvent(2060, on5); } }

		// ENGINE_EVENT on_6;
		private static EngineEventDelegate on6;
		public static EngineEventDelegate On6 { get { return on6; } set { on6 = value; SetEvent(2064, on6); } }

		// ENGINE_EVENT on_7;
		private static EngineEventDelegate on7;
		public static EngineEventDelegate On7 { get { return on7; } set { on7 = value; SetEvent(2068, on7); } }

		// ENGINE_EVENT on_8;
		private static EngineEventDelegate on8;
		public static EngineEventDelegate On8 { get { return on8; } set { on8 = value; SetEvent(2072, on8); } }

		// ENGINE_EVENT on_9;
		private static EngineEventDelegate on9;
		public static EngineEventDelegate On9 { get { return on9; } set { on9 = value; SetEvent(2076, on9); } }

		// ENGINE_EVENT on_0;
		private static EngineEventDelegate on0;
		public static EngineEventDelegate On0 { get { return on0; } set { on0 = value; SetEvent(2080, on0); } }

		// ENGINE_EVENT on_pause;
		private static EngineEventDelegate onPause;
		public static EngineEventDelegate OnPause { get { return onPause; } set { onPause = value; SetEvent(2084, onPause); } }

		// ENGINE_EVENT on_mouse_left;
		private static EngineEventDelegate onMouseLeft;
		public static EngineEventDelegate OnMouseLeft { get { return onMouseLeft; } set { onMouseLeft = value; SetEvent(2088, onMouseLeft); } }

		// ENGINE_EVENT on_mouse_right;
		private static EngineEventDelegate onMouseRight;
		public static EngineEventDelegate OnMouseRight { get { return onMouseRight; } set { onMouseRight = value; SetEvent(2092, onMouseRight); } }

		// ENGINE_EVENT on_mouse_middle;
		private static EngineEventDelegate onMouseMiddle;
		public static EngineEventDelegate OnMouseMiddle { get { return onMouseMiddle; } set { onMouseMiddle = value; SetEvent(2096, onMouseMiddle); } }

		// ENGINE_EVENT on_joy1;
		private static EngineEventDelegate onJoy1;
		public static EngineEventDelegate OnJoy1 { get { return onJoy1; } set { onJoy1 = value; SetEvent(2100, onJoy1); } }

		// ENGINE_EVENT on_joy2;
		private static EngineEventDelegate onJoy2;
		public static EngineEventDelegate OnJoy2 { get { return onJoy2; } set { onJoy2 = value; SetEvent(2104, onJoy2); } }

		// ENGINE_EVENT on_joy3;
		private static EngineEventDelegate onJoy3;
		public static EngineEventDelegate OnJoy3 { get { return onJoy3; } set { onJoy3 = value; SetEvent(2108, onJoy3); } }

		// ENGINE_EVENT on_joy4;
		private static EngineEventDelegate onJoy4;
		public static EngineEventDelegate OnJoy4 { get { return onJoy4; } set { onJoy4 = value; SetEvent(2112, onJoy4); } }

		// ENGINE_EVENT on_joy5;
		private static EngineEventDelegate onJoy5;
		public static EngineEventDelegate OnJoy5 { get { return onJoy5; } set { onJoy5 = value; SetEvent(2116, onJoy5); } }

		// ENGINE_EVENT on_joy6;
		private static EngineEventDelegate onJoy6;
		public static EngineEventDelegate OnJoy6 { get { return onJoy6; } set { onJoy6 = value; SetEvent(2120, onJoy6); } }

		// ENGINE_EVENT on_joy7;
		private static EngineEventDelegate onJoy7;
		public static EngineEventDelegate OnJoy7 { get { return onJoy7; } set { onJoy7 = value; SetEvent(2124, onJoy7); } }

		// ENGINE_EVENT on_joy8;
		private static EngineEventDelegate onJoy8;
		public static EngineEventDelegate OnJoy8 { get { return onJoy8; } set { onJoy8 = value; SetEvent(2128, onJoy8); } }

		// ENGINE_EVENT on_joy9;
		private static EngineEventDelegate onJoy9;
		public static EngineEventDelegate OnJoy9 { get { return onJoy9; } set { onJoy9 = value; SetEvent(2132, onJoy9); } }

		// ENGINE_EVENT on_joy10;
		private static EngineEventDelegate onJoy10;
		public static EngineEventDelegate OnJoy10 { get { return onJoy10; } set { onJoy10 = value; SetEvent(2136, onJoy10); } }

		// ENGINE_EVENT on_joy11;
		private static EngineEventDelegate onJoy11;
		public static EngineEventDelegate OnJoy11 { get { return onJoy11; } set { onJoy11 = value; SetEvent(2140, onJoy11); } }

		// ENGINE_EVENT on_joy12;
		private static EngineEventDelegate onJoy12;
		public static EngineEventDelegate OnJoy12 { get { return onJoy12; } set { onJoy12 = value; SetEvent(2144, onJoy12); } }

		// ENGINE_EVENT on_joy2_1;
		private static EngineEventDelegate onJoy21;
		public static EngineEventDelegate OnJoy21 { get { return onJoy21; } set { onJoy21 = value; SetEvent(2148, onJoy21); } }

		// ENGINE_EVENT on_joy2_2;
		private static EngineEventDelegate onJoy22;
		public static EngineEventDelegate OnJoy22 { get { return onJoy22; } set { onJoy22 = value; SetEvent(2152, onJoy22); } }

		// ENGINE_EVENT on_joy2_3;
		private static EngineEventDelegate onJoy23;
		public static EngineEventDelegate OnJoy23 { get { return onJoy23; } set { onJoy23 = value; SetEvent(2156, onJoy23); } }

		// ENGINE_EVENT on_joy2_4;
		private static EngineEventDelegate onJoy24;
		public static EngineEventDelegate OnJoy24 { get { return onJoy24; } set { onJoy24 = value; SetEvent(2160, onJoy24); } }

		// ENGINE_EVENT on_joy2_5;
		private static EngineEventDelegate onJoy25;
		public static EngineEventDelegate OnJoy25 { get { return onJoy25; } set { onJoy25 = value; SetEvent(2164, onJoy25); } }

		// ENGINE_EVENT on_joy2_6;
		private static EngineEventDelegate onJoy26;
		public static EngineEventDelegate OnJoy26 { get { return onJoy26; } set { onJoy26 = value; SetEvent(2168, onJoy26); } }

		// ENGINE_EVENT on_joy2_7;
		private static EngineEventDelegate onJoy27;
		public static EngineEventDelegate OnJoy27 { get { return onJoy27; } set { onJoy27 = value; SetEvent(2172, onJoy27); } }

		// ENGINE_EVENT on_joy2_8;
		private static EngineEventDelegate onJoy28;
		public static EngineEventDelegate OnJoy28 { get { return onJoy28; } set { onJoy28 = value; SetEvent(2176, onJoy28); } }

		// ENGINE_EVENT on_joy2_9;
		private static EngineEventDelegate onJoy29;
		public static EngineEventDelegate OnJoy29 { get { return onJoy29; } set { onJoy29 = value; SetEvent(2180, onJoy29); } }

		// ENGINE_EVENT on_joy2_10;
		private static EngineEventDelegate onJoy210;
		public static EngineEventDelegate OnJoy210 { get { return onJoy210; } set { onJoy210 = value; SetEvent(2184, onJoy210); } }

		// ENGINE_EVENT on_joy2_11;
		private static EngineEventDelegate onJoy211;
		public static EngineEventDelegate OnJoy211 { get { return onJoy211; } set { onJoy211 = value; SetEvent(2188, onJoy211); } }

		// ENGINE_EVENT on_joy2_12;
		private static EngineEventDelegate onJoy212;
		public static EngineEventDelegate OnJoy212 { get { return onJoy212; } set { onJoy212 = value; SetEvent(2192, onJoy212); } }

		// ENGINE_EVENT on_anykey;
		private static EngineEventDelegate onAnykey;
		public static EngineEventDelegate OnAnykey { get { return onAnykey; } set { onAnykey = value; SetEvent(2196, onAnykey); } }

		// ENGINE_EVENT on_click;
		private static EngineEventDelegate onClick;
		public static EngineEventDelegate OnClick { get { return onClick; } set { onClick = value; SetEvent(2200, onClick); } }

		// ENGINE_EVENT on_mouse_stop;
		private static EngineEventDelegate onMouseStop;
		public static EngineEventDelegate OnMouseStop { get { return onMouseStop; } set { onMouseStop = value; SetEvent(2204, onMouseStop); } }

		// ENGINE_EVENT on_close;
		private static EngineEventDelegate onClose;
		public static EngineEventDelegate OnClose { get { return onClose; } set { onClose = value; SetEvent(2208, onClose); } }

		// ENGINE_EVENT on_load;
		private static EngineEventDelegate onLoad;
		public static EngineEventDelegate OnLoad { get { return onLoad; } set { onLoad = value; SetEvent(2212, onLoad); } }

		// ENGINE_EVENT on_level;
		private static EngineEventDelegate onLevel;
		public static EngineEventDelegate OnLevel { get { return onLevel; } set { onLevel = value; SetEvent(2216, onLevel); } }

		// ENGINE_EVENT on_server;
		private static EngineEventDelegate onServer;
		public static EngineEventDelegate OnServer { get { return onServer; } set { onServer = value; SetEvent(2220, onServer); } }

		// ENGINE_EVENT on_client;
		private static EngineEventDelegate onClient;
		public static EngineEventDelegate OnClient { get { return onClient; } set { onClient = value; SetEvent(2224, onClient); } }

		// ENGINE_EVENT on_d3d_lost;
		private static EngineEventDelegate onD3dLost;
		public static EngineEventDelegate OnD3dLost { get { return onD3dLost; } set { onD3dLost = value; SetEvent(2228, onD3dLost); } }

		// ENGINE_EVENT on_d3d_reset;
		private static EngineEventDelegate onD3dReset;
		public static EngineEventDelegate OnD3dReset { get { return onD3dReset; } set { onD3dReset = value; SetEvent(2232, onD3dReset); } }

		// ENGINE_EVENT render_sky;
		private static EngineEventDelegate renderSky;
		public static EngineEventDelegate RenderSky { get { return renderSky; } set { renderSky = value; SetEvent(2236, renderSky); } }

		// ENGINE_EVENT render_world;
		private static EngineEventDelegate renderWorld;
		public static EngineEventDelegate RenderWorld { get { return renderWorld; } set { renderWorld = value; SetEvent(2240, renderWorld); } }

		// ENGINE_EVENT render_entities;
		private static EngineEventDelegate renderEntities;
		public static EngineEventDelegate RenderEntities { get { return renderEntities; } set { renderEntities = value; SetEvent(2244, renderEntities); } }

		// ENGINE_EVENT render_solid;
		private static EngineEventDelegate renderSolid;
		public static EngineEventDelegate RenderSolid { get { return renderSolid; } set { renderSolid = value; SetEvent(2248, renderSolid); } }

		// ENGINE_EVENT on_exit;
		private static EngineEventDelegate onExit;
		public static EngineEventDelegate OnExit { get { return onExit; } set { onExit = value; SetEvent(2252, onExit); } }

		// ENGINE_EVENT on_frame;
		private static EngineEventDelegate onFrame;
		public static EngineEventDelegate OnFrame { get { return onFrame; } set { onFrame = value; SetEvent(2256, onFrame); } }

		// ENGINE_EVENT on_message;
		private static EngineEventDelegate onMessage;
		public static EngineEventDelegate OnMessage { get { return onMessage; } set { onMessage = value; SetEvent(2260, onMessage); } }

		// ENGINE_EVENT on_maximize;
		private static EngineEventDelegate onMaximize;
		public static EngineEventDelegate OnMaximize { get { return onMaximize; } set { onMaximize = value; SetEvent(2264, onMaximize); } }

		// ENGINE_EVENT on_minimize;
		private static EngineEventDelegate onMinimize;
		public static EngineEventDelegate OnMinimize { get { return onMinimize; } set { onMinimize = value; SetEvent(2268, onMinimize); } }

		// ENGINE_EVENT on_resize;
		private static EngineEventDelegate onResize;
		public static EngineEventDelegate OnResize { get { return onResize; } set { onResize = value; SetEvent(2272, onResize); } }

		// ENGINE_EVENT on_level_load;
		private static EngineEventDelegate onLevelLoad;
		public static EngineEventDelegate OnLevelLoad { get { return onLevelLoad; } set { onLevelLoad = value; SetEvent(2276, onLevelLoad); } }

		// ENGINE_EVENT on_ent_remove;
		private static EngineEventDelegate onEntRemove;
		public static EngineEventDelegate OnEntRemove { get { return onEntRemove; } set { onEntRemove = value; SetEvent(2280, onEntRemove); } }

		// ENGINE_EVENT render_layer;
		private static EngineEventDelegate renderLayer;
		public static EngineEventDelegate RenderLayer { get { return renderLayer; } set { renderLayer = value; SetEvent(2284, renderLayer); } }

		// ENGINE_VIEW camera;

		// ENGINE_VIEW light_view;

		// ENGINE_VIEW render_view;

		// ENGINE_ENTITY watched;
		public static Entity Watched { get { return GetEntity(2340); } set { SetEntity(2340, value); } }

		// ENGINE_ENTITY me;
		public static Entity Me { get { return GetEntity(2344); } set { SetEntity(2344, value); } }

		// ENGINE_ENTITY you;
		public static Entity You { get { return GetEntity(2348); } set { SetEntity(2348, value); } }

		// ENGINE_ENTITY sky_cube_level;
		public static Entity SkyCubeLevel { get { return GetEntity(2352); } set { SetEntity(2352, value); } }

		// ENGINE_ENTITY sky_dome_level;
		public static Entity SkyDomeLevel { get { return GetEntity(2356); } set { SetEntity(2356, value); } }

		// ENGINE_ENTITY mouse_ent;
		public static Entity MouseEnt { get { return GetEntity(2360); } set { SetEntity(2360, value); } }

		// ENGINE_BMAP mouse_map;

		// void* render_mesh;
		public static IntPtr RenderMesh { get { return GetPtr(2384); } set { SetPtr(2384, value); } }

		// ENGINE_MATERIAL mtl;
		public static Material Mtl { get { return GetMaterial(2388); } set { SetMaterial(2388, value); } }

		// ENGINE_MATERIAL mtl_flat;
		public static Material MtlFlat { get { return GetMaterial(2392); } set { SetMaterial(2392, value); } }

		// ENGINE_MATERIAL mtl_shaded;
		public static Material MtlShaded { get { return GetMaterial(2396); } set { SetMaterial(2396, value); } }

		// ENGINE_MATERIAL mtl_model;
		public static Material MtlModel { get { return GetMaterial(2400); } set { SetMaterial(2400, value); } }

		// ENGINE_MATERIAL mtl_terrain;
		public static Material MtlTerrain { get { return GetMaterial(2404); } set { SetMaterial(2404, value); } }

		// ENGINE_MATERIAL mtl_sprite;
		public static Material MtlSprite { get { return GetMaterial(2408); } set { SetMaterial(2408, value); } }

		// ENGINE_MATERIAL mtl_particle;
		public static Material MtlParticle { get { return GetMaterial(2412); } set { SetMaterial(2412, value); } }

		// ENGINE_MATERIAL mtl_metal;
		public static Material MtlMetal { get { return GetMaterial(2416); } set { SetMaterial(2416, value); } }

		// ENGINE_MATERIAL mtl_sky;
		public static Material MtlSky { get { return GetMaterial(2420); } set { SetMaterial(2420, value); } }

		// ENGINE_MATERIAL mtl_shadow;
		public static Material MtlShadow { get { return GetMaterial(2424); } set { SetMaterial(2424, value); } }

		// ENGINE_MATERIAL mtl_unlit;
		public static Material MtlUnlit { get { return GetMaterial(2428); } set { SetMaterial(2428, value); } }

		// ENGINE_STRING debug_str;

		// ENGINE_STRING watch_str;

		// ENGINE_STRING delimit_str;

		// ENGINE_STRING tex_name;

		// ENGINE_STRING app_name;

		// ENGINE_STRING level_name;

		// ENGINE_STRING player_name;

		// ENGINE_STRING session_name;

		// ENGINE_STRING server_name;

		// ENGINE_STRING server_ip;

		// ENGINE_STRING work_dir;

		// ENGINE_STRING save_dir;

		// ENGINE_STRING exe_dir;

		// ENGINE_ENTITY player;
		public static Entity Player { get { return GetEntity(2484); } set { SetEntity(2484, value); } }

		// ENGINE_STRING user_name;

		// ENGINE_ENTITY passable_ent;
		public static Entity PassableEnt { get { return GetEntity(2492); } set { SetEntity(2492, value); } }

		// ENGINE_STRING path_name;

		// ENGINE_STRING command_str;

		// ENGINE_ENTITY level_ent;
		public static Entity LevelEnt { get { return GetEntity(2504); } set { SetEntity(2504, value); } }

		// ENGINE_PANEL mouse_panel;

		// ENGINE_ void* render_d3dmaterial;
		public static IntPtr RenderD3dmaterial { get { return GetPtr(2516); } set { SetPtr(2516, value); } }

		// ENGINE_ void* render_d3dxeffect;
		public static IntPtr RenderD3dxeffect { get { return GetPtr(2520); } set { SetPtr(2520, value); } }

		// ENGINE_MATERIAL render_material;
		public static Material RenderMaterial { get { return GetMaterial(2524); } set { SetMaterial(2524, value); } }

		// ENGINE_BMAP render_target;

		// ENGINE_BMAP render_stencil;

		// ENGINE_ void* render_zbuffer;
		public static IntPtr RenderZbuffer { get { return GetPtr(2536); } set { SetPtr(2536, value); } }

		// ENGINE_BMAP video_overlay;

		// ENGINE_BMAP render_lightmap;

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

		//   void (*SendPacket)(long to,void *data,long size,long flags);
//   void (*SendPacket)(long to,void *data,long size,long flags);

		//   void (*ReceivePacket)(long from,void *data,long size);
//   void (*ReceivePacket)(long from,void *data,long size);

		//   long (*ScanMessage)(UINT message, WPARAM w_param, LPARAM l_param);
//   long (*ScanMessage)(UINT message, WPARAM w_param, LPARAM l_param);

		//   long (*GetObj)(char *name);
//   long (*GetObj)(char *name);

		//   long (*GetFunc)(char *name);
//   long (*GetFunc)(char *name);

		//   long (*CallFunc)(long,long,long,long,long);
//   long (*CallFunc)(long,long,long,long,long);

		// ENGINE_ BOOL isPointer;
// ENGINE_ BOOL isPointer;

		// ENGINE_ void *EngineFunctions;
// ENGINE_ void *EngineFunctions;

		// ENGINE_ void* pdi;
		public static IntPtr Pdi { get { return GetPtr(2648); } set { SetPtr(2648, value); } }

		// ENGINE_ void* pdimouse;
		public static IntPtr Pdimouse { get { return GetPtr(2652); } set { SetPtr(2652, value); } }

		// ENGINE_ void* pdikbd;
		public static IntPtr Pdikbd { get { return GetPtr(2656); } set { SetPtr(2656, value); } }

		// ENGINE_ void* pdijoy;
		public static IntPtr Pdijoy { get { return GetPtr(2660); } set { SetPtr(2660, value); } }

		// ENGINE_ void** pbody;
// ENGINE_ void** pbody;

		// ENGINE_ void* pvertexdecl;
		public static IntPtr Pvertexdecl { get { return GetPtr(2668); } set { SetPtr(2668, value); } }

		// ENGINE_ void* pds;
		public static IntPtr Pds { get { return GetPtr(2680); } set { SetPtr(2680, value); } }

		// ENGINE_ void* pdsb;
		public static IntPtr Pdsb { get { return GetPtr(2684); } set { SetPtr(2684, value); } }

		// ENGINE_ void* pd3d;
		public static IntPtr Pd3d { get { return GetPtr(2688); } set { SetPtr(2688, value); } }

		// ENGINE_ void* pd3ddev;
		public static IntPtr Pd3ddev { get { return GetPtr(2692); } set { SetPtr(2692, value); } }

		// ENGINE_ HWND hWnd;
// ENGINE_ HWND hWnd;

		// ENGINE_ void* pd3dcaps;
		public static IntPtr Pd3dcaps { get { return GetPtr(2700); } set { SetPtr(2700, value); } }

		// ENGINE_ long hInstance;
// ENGINE_ long hInstance;

		// ENGINE_ HWND hWndTarget;
// ENGINE_ HWND hWndTarget;

		// ENGINE_ RECT* pRectTarget;
// ENGINE_ RECT* pRectTarget;

		// ENGINE_ char** pPaths;
// ENGINE_ char** pPaths;

		// ENGINE_ void* pVars;
		public static IntPtr PVars { get { return GetPtr(2720); } set { SetPtr(2720, value); } }

		// ENGINE_ HWND hWndParent;
// ENGINE_ HWND hWndParent;

		// ENGINE_ void* pdsbs;
		public static IntPtr Pdsbs { get { return GetPtr(2740); } set { SetPtr(2740, value); } }

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
	}
}
