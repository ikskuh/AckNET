namespace AckNET
{
using System;
using System.Runtime.InteropServices;

partial class Entity
{


public string FileName { get { return GetString(12); } }

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

public EntityFlags Flags { get { return (EntityFlags)GetInt(52); } set { SetInt(52, (int)value); } }

public ackvar Frame { get { return GetVar(56); } set { SetVar(56, value); } }

public ackvar NextFrame { get { return GetVar(60); } set { SetVar(60, value); } }

public ackvar Skin { get { return GetVar(64); } set { SetVar(64, value); } }

public ackvar Ambient { get { return GetVar(68); } set { SetVar(68, value); } }

public ackvar Albedo { get { return GetVar(72); } set { SetVar(72, value); } }

public ackvar Alpha { get { return GetVar(76); } set { SetVar(76, value); } }

public ackvar LightRange { get { return GetVar(80); } set { SetVar(80, value); } }

public Color Color { get { return GetColor(84); } set { SetColor(84, value); } }
public ackvar Red { get { return GetVar(84); } set { SetVar(84, value); } }
public ackvar Green { get { return GetVar(88); } set { SetVar(88, value); } }
public ackvar Blue { get { return GetVar(92); } set { SetVar(92, value); } }

public EventMask EventMask { get { return (EventMask)GetInt(96); } set { SetInt(96, (int)value); } }

public EntityEFlags EventFlags { get { return (EntityEFlags)GetInt(100); } set { SetInt(100, (int)value); } }

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

public ackvar FloorDist { get { return GetVar(136); } }

public SendMask SendMask { get { return (SendMask)GetInt(140); } set { SetInt(140, (int)value); } }

public ackvar ClientID { get { return GetVar(144); } }

public ackvar this[int idx] {
get {
if(idx < 0 || idx >= 100) throw new IndexOutOfRangeException();
return GetVar(148 + 4 * idx);
}
set {
if(idx < 0 || idx >= 100) throw new IndexOutOfRangeException();
SetVar(148 + 4 * idx, value);
}
}

public ackvar pose { get { return GetVar(548); } set { SetVar(548, value); } }

public Material Material { get { return Get<Material>(552); } set { Set(552, value); } }

public ackvar U { get { return GetVar(556); } set { SetVar(556, value); } }

public ackvar V { get { return GetVar(560); } set { SetVar(560, value); } }

public ackvar Group { get { return GetVar(564); } set { SetVar(564, value); } }

public EntityFlags2 Flags2 { get { return (EntityFlags2)GetInt(568); } set { SetInt(568, (int)value); } }

public string Attachname { get { return GetString(572); } }

NativeEvent neEvent;
public EngineEventDelegate Event
{
get { return (EngineEventDelegate)GetEvent(576, ref neEvent, typeof(EngineEventDelegate)); }
set { SetEvent(576, ref neEvent, value); }
}

NativeEvent neLocal;
public EngineEventDelegate Local
{
get { return (EngineEventDelegate)GetEvent(580, ref neLocal, typeof(EngineEventDelegate)); }
set { SetEvent(580, ref neLocal, value); }
}

public ackvar layer { get { return GetVar(584); } }

public int VMask { get { return GetInt(588); } set { SetInt(588, value); } }

NativeString nsString1 = new NativeString();
public string String1 { get { return GetString(592); } set { SetString(592, nsString1, value); } }

NativeString nsString2 = new NativeString();
public string String2 { get { return GetString(596); } set { SetString(596, nsString2, value); } }

public float Radius { get { return GetFloat(600); } }

public int PathIndex { get { return GetInt(604); } }

public IntPtr Model { get { return GetPtr(608); } }

public Entity Shadow { get { return Get<Entity>(612); } }

public Entity Parent { get { return Get<Entity>(616); } set { Set(616, value); } }

public Bitmap LightMap { get { return Get<Bitmap>(620); } }

public IntPtr Body { get { return GetPtr(624); } }

public ackvar ClipFactor { get { return GetVar(628); } set { SetVar(628, value); } }

}
partial class AckString
{


public string Characters { get { return GetString(12); } }

public int Length { get { return GetInt(16); } }

public StringFlags Flags { get { return (StringFlags)GetInt(20); } }

}
partial class Sound
{


public int Length { get { return GetInt(12); } }

public IntPtr Buffer { get { return GetPtr(16); } }

public SoundType Type { get { return (SoundType)GetInt(20); } }

}
partial class Bitmap
{


public int Width { get { return GetInt(12); } }

public int Height { get { return GetInt(16); } }

public int BytesPerPixel { get { return GetInt(20); } }

public IntPtr Pixels { get { return GetPtr(28); } }

public BitmapFlags Flags { get { return (BitmapFlags)GetInt(32); } }

public IntPtr Texture { get { return GetPtr(36); } }

public float U1 { get { return GetFloat(40); } }

public float V1 { get { return GetFloat(44); } }

public float U2 { get { return GetFloat(48); } }

public float V2 { get { return GetFloat(52); } }

public float U { get { return GetFloat(56); } }

public float V { get { return GetFloat(60); } }

public int ReferenceCount { get { return GetInt(64); } }

public int FinalWidth { get { return GetInt(68); } }

public int FinalHeight { get { return GetInt(72); } }

public int FinalBytesPerPixel { get { return GetInt(76); } }

public int Pitch { get { return GetInt(80); } }

public int FinalPitch { get { return GetInt(84); } }

public int MipLevels { get { return GetInt(88); } }

public int FinalFormat { get { return GetInt(92); } }

public IntPtr FinalBits { get { return GetPtr(96); } }

}
partial class Material
{


public Color Ambient { get { return GetColor(12); } set { SetColor(12, value); } }
public ackvar AmbientRed { get { return GetVar(12); } set { SetVar(12, value); } }
public ackvar AmbientGreen { get { return GetVar(16); } set { SetVar(16, value); } }
public ackvar AmbientBlue { get { return GetVar(20); } set { SetVar(20, value); } }

public Color Diffuse { get { return GetColor(24); } set { SetColor(24, value); } }
public ackvar DiffuseRed { get { return GetVar(24); } set { SetVar(24, value); } }
public ackvar DiffuseGreen { get { return GetVar(28); } set { SetVar(28, value); } }
public ackvar DiffuseBlue { get { return GetVar(32); } set { SetVar(32, value); } }

public Color Specular { get { return GetColor(36); } set { SetColor(36, value); } }
public ackvar SpecularRed { get { return GetVar(36); } set { SetVar(36, value); } }
public ackvar SpecularGreen { get { return GetVar(40); } set { SetVar(40, value); } }
public ackvar SpecularBlue { get { return GetVar(44); } set { SetVar(44, value); } }

public Color Emissive { get { return GetColor(48); } set { SetColor(48, value); } }
public ackvar EmissiveRed { get { return GetVar(48); } set { SetVar(48, value); } }
public ackvar EmissiveGreen { get { return GetVar(52); } set { SetVar(52, value); } }
public ackvar EmissiveBlue { get { return GetVar(56); } set { SetVar(56, value); } }

public Color Map { get { return GetColor(60); } set { SetColor(60, value); } }
public ackvar MapRed { get { return GetVar(60); } set { SetVar(60, value); } }
public ackvar MapGreen { get { return GetVar(64); } set { SetVar(64, value); } }
public ackvar MapBlue { get { return GetVar(68); } set { SetVar(68, value); } }

public ackvar Alpha { get { return GetVar(72); } set { SetVar(72, value); } }

public ackvar Power { get { return GetVar(76); } set { SetVar(76, value); } }

public ackvar Albedo { get { return GetVar(80); } set { SetVar(80, value); } }

public ackvar Scale1 { get { return GetVar(84); } set { SetVar(84, value); } }

public ackvar Scale2 { get { return GetVar(88); } set { SetVar(88, value); } }

public ackvar Cycle { get { return GetVar(92); } set { SetVar(92, value); } }

public ackvar this[int idx] {
get {
if(idx < 0 || idx >= 20) throw new IndexOutOfRangeException();
return GetVar(96 + 4 * idx);
}
set {
if(idx < 0 || idx >= 20) throw new IndexOutOfRangeException();
SetVar(96 + 4 * idx, value);
}
}

public MaterialFlags Flags { get { return (MaterialFlags)GetInt(240); } set { SetInt(240, (int)value); } }

NativeString nsEffect = new NativeString();
public string Effect { get { return GetString(244); } set { SetString(244, nsEffect, value); } }

public ackvar LOD { get { return GetVar(248); } set { SetVar(248, value); } }

public Bitmap Skin1 { get { return Get<Bitmap>(252); } set { Set(252, value); } }

public Bitmap Skin2 { get { return Get<Bitmap>(256); } set { Set(256, value); } }

public Bitmap Skin3 { get { return Get<Bitmap>(260); } set { Set(260, value); } }

public Bitmap Skin4 { get { return Get<Bitmap>(264); } set { Set(264, value); } }

NativeEvent neEvent;
public EngineEventDelegate Event
{
get { return (EngineEventDelegate)GetEvent(268, ref neEvent, typeof(EngineEventDelegate)); }
set { SetEvent(268, ref neEvent, value); }
}

public IntPtr D3DEffect { get { return GetPtr(272); } }

public IntPtr D3DMaterial9 { get { return GetPtr(276); } }

NativeString nsTechnique = new NativeString();
public string Technique { get { return GetString(280); } set { SetString(280, nsTechnique, value); } }

public ackvar MaxBones { get { return GetVar(284); } set { SetVar(284, value); } }

}
partial class Particle
{


public ackvar LifeSpan { get { return GetVar(12); } set { SetVar(12, value); } }

public Vector Position { get { return GetVector(16); } set { SetVector(16, value); } }
public ackvar X { get { return GetVar(16); } set { SetVar(16, value); } }
public ackvar Y { get { return GetVar(20); } set { SetVar(20, value); } }
public ackvar Z { get { return GetVar(24); } set { SetVar(24, value); } }

public Vector Velocity { get { return GetVector(28); } set { SetVector(28, value); } }
public ackvar VelX { get { return GetVar(28); } set { SetVar(28, value); } }
public ackvar VelY { get { return GetVar(32); } set { SetVar(32, value); } }
public ackvar VelZ { get { return GetVar(36); } set { SetVar(36, value); } }

public ackvar Size { get { return GetVar(40); } set { SetVar(40, value); } }

public Bitmap Bitmap { get { return Get<Bitmap>(44); } set { Set(44, value); } }

NativeEvent neEvent;
public NativeParticleEffect Event
{
get { return (NativeParticleEffect)GetEvent(48, ref neEvent, typeof(NativeParticleEffect)); }
set { SetEvent(48, ref neEvent, value); }
}

public ParticleFlags Flags { get { return (ParticleFlags)GetInt(52); } set { SetInt(52, (int)value); } }

public Vector Skill { get { return GetVector(56); } set { SetVector(56, value); } }
public ackvar SkillX { get { return GetVar(56); } set { SetVar(56, value); } }
public ackvar SkillY { get { return GetVar(60); } set { SetVar(60, value); } }
public ackvar SkillZ { get { return GetVar(64); } set { SetVar(64, value); } }

public ackvar Gravity { get { return GetVar(68); } set { SetVar(68, value); } }

public ackvar Angle { get { return GetVar(72); } set { SetVar(72, value); } }

public ackvar Alpha { get { return GetVar(76); } set { SetVar(76, value); } }

public Entity Creator { get { return Get<Entity>(80); } }

public Color Color { get { return GetColor(84); } set { SetColor(84, value); } }
public ackvar Red { get { return GetVar(84); } set { SetVar(84, value); } }
public ackvar Green { get { return GetVar(88); } set { SetVar(88, value); } }
public ackvar Blue { get { return GetVar(92); } set { SetVar(92, value); } }

public ackvar this[int idx] {
get {
if(idx < 0 || idx >= 4) throw new IndexOutOfRangeException();
return GetVar(96 + 4 * idx);
}
set {
if(idx < 0 || idx >= 4) throw new IndexOutOfRangeException();
SetVar(96 + 4 * idx, value);
}
}

public IntPtr D3DMesh { get { return GetPtr(112); } }

public Material Material { get { return Get<Material>(116); } set { Set(116, value); } }

}
partial class Contact
{


public Vector Position { get { return GetVector(4); } set { SetVector(4, value); } }
public ackvar X { get { return GetVar(4); } set { SetVar(4, value); } }
public ackvar Y { get { return GetVar(8); } set { SetVar(8, value); } }
public ackvar Z { get { return GetVar(12); } set { SetVar(12, value); } }

public Vector Normal { get { return GetVector(16); } set { SetVector(16, value); } }
public ackvar NormalX { get { return GetVar(16); } set { SetVar(16, value); } }
public ackvar NormalY { get { return GetVar(20); } set { SetVar(20, value); } }
public ackvar NormalZ { get { return GetVar(24); } set { SetVar(24, value); } }

public ackvar U1 { get { return GetVar(28); } set { SetVar(28, value); } }

public ackvar V1 { get { return GetVar(32); } set { SetVar(32, value); } }

public ackvar U2 { get { return GetVar(36); } set { SetVar(36, value); } }

public ackvar V2 { get { return GetVar(40); } set { SetVar(40, value); } }

public ackvar Vertex { get { return GetVar(44); } set { SetVar(44, value); } }

public ackvar Triangle { get { return GetVar(48); } set { SetVar(48, value); } }

public ackvar Chunk { get { return GetVar(52); } set { SetVar(52, value); } }

public IntPtr Model { get { return GetPtr(56); } }

public ackvar Light { get { return GetVar(60); } set { SetVar(60, value); } }

public ackvar Alpha { get { return GetVar(64); } set { SetVar(64, value); } }

public Color Color { get { return GetColor(68); } set { SetColor(68, value); } }
public ackvar Red { get { return GetVar(68); } set { SetVar(68, value); } }
public ackvar Green { get { return GetVar(72); } set { SetVar(72, value); } }
public ackvar Blue { get { return GetVar(76); } set { SetVar(76, value); } }

public HitFlags Flags { get { return (HitFlags)GetInt(80); } set { SetInt(80, (int)value); } }

public Entity Entity { get { return Get<Entity>(84); } set { Set(84, value); } }

public Bitmap Skin1 { get { return Get<Bitmap>(88); } set { Set(88, value); } }

public Bitmap Skin2 { get { return Get<Bitmap>(92); } set { Set(92, value); } }

public Bitmap Skin3 { get { return Get<Bitmap>(96); } set { Set(96, value); } }

public Bitmap Skin4 { get { return Get<Bitmap>(100); } set { Set(100, value); } }

public string TextureName { get { return GetString(104); } }

public ackvar Subset { get { return GetVar(108); } set { SetVar(108, value); } }

}
partial class Font
{


public int DX { get { return GetInt(12); } }

public int DY { get { return GetInt(16); } }

public int CharacterCount { get { return GetInt(20); } }

public int CharactersPerLine { get { return GetInt(24); } }

public string Type { get { return GetString(28); } }

}
partial class Text
{


public ackvar Layer { get { return GetVar(16); } }

public ackvar PosX { get { return GetVar(20); } set { SetVar(20, value); } }

public ackvar PosY { get { return GetVar(24); } set { SetVar(24, value); } }

public TextFlags Flags { get { return (TextFlags)GetInt(28); } set { SetInt(28, (int)value); } }

public ackvar Alpha { get { return GetVar(32); } set { SetVar(32, value); } }

public ackvar OffsetY { get { return GetVar(36); } set { SetVar(36, value); } }

public ackvar SizeY { get { return GetVar(40); } set { SetVar(40, value); } }

public Font Font { get { return Get<Font>(44); } set { Set(44, value); } }

public ackvar ScaleX { get { return GetVar(56); } set { SetVar(56, value); } }

public ackvar ScaleY { get { return GetVar(60); } set { SetVar(60, value); } }

public Color Color { get { return GetColor(64); } set { SetColor(64, value); } }
public ackvar Red { get { return GetVar(64); } set { SetVar(64, value); } }
public ackvar Green { get { return GetVar(68); } set { SetVar(68, value); } }
public ackvar Blue { get { return GetVar(72); } set { SetVar(72, value); } }

public ackvar Count { get { return GetVar(76); } }

public Bitmap TargetMap { get { return Get<Bitmap>(80); } set { Set(80, value); } }

public ackvar SizeX { get { return GetVar(88); } set { SetVar(88, value); } }

public ackvar SkillX { get { return GetVar(92); } set { SetVar(92, value); } }

public ackvar SkillY { get { return GetVar(96); } set { SetVar(96, value); } }

}
partial class Panel
{


public ackvar Layer { get { return GetVar(16); } }

public ackvar PosX { get { return GetVar(20); } set { SetVar(20, value); } }

public ackvar PosY { get { return GetVar(24); } set { SetVar(24, value); } }

public PanelFlags Flags { get { return (PanelFlags)GetInt(28); } set { SetInt(28, (int)value); } }

public ackvar Alpha { get { return GetVar(32); } set { SetVar(32, value); } }

public Bitmap Bitmap { get { return Get<Bitmap>(36); } set { Set(36, value); } }

public ackvar ScaleX { get { return GetVar(40); } set { SetVar(40, value); } }

public ackvar ScaleY { get { return GetVar(44); } set { SetVar(44, value); } }

public Color Color { get { return GetColor(48); } set { SetColor(48, value); } }
public ackvar Red { get { return GetVar(48); } set { SetVar(48, value); } }
public ackvar Green { get { return GetVar(52); } set { SetVar(52, value); } }
public ackvar Blue { get { return GetVar(56); } set { SetVar(56, value); } }

public ackvar SizeX { get { return GetVar(60); } set { SetVar(60, value); } }

public ackvar SizeY { get { return GetVar(64); } set { SetVar(64, value); } }

public ackvar Angle { get { return GetVar(68); } set { SetVar(68, value); } }

public ackvar CenterX { get { return GetVar(72); } set { SetVar(72, value); } }

public ackvar CenterY { get { return GetVar(76); } set { SetVar(76, value); } }

public Bitmap MouseMap { get { return Get<Bitmap>(80); } set { Set(80, value); } }

public Bitmap TargetMap { get { return Get<Bitmap>(84); } set { Set(84, value); } }

NativeEvent neEvent;
public EngineEventDelegate Event
{
get { return (EngineEventDelegate)GetEvent(88, ref neEvent, typeof(EngineEventDelegate)); }
set { SetEvent(88, ref neEvent, value); }
}

public ackvar SkillX { get { return GetVar(92); } set { SetVar(92, value); } }

public ackvar SkillY { get { return GetVar(96); } set { SetVar(96, value); } }

}
partial class View
{


public ackvar Layer { get { return GetVar(16); } }

public ackvar PosX { get { return GetVar(20); } set { SetVar(20, value); } }

public ackvar PosY { get { return GetVar(24); } set { SetVar(24, value); } }

public ViewFlags Flags { get { return (ViewFlags)GetInt(28); } set { SetInt(28, (int)value); } }

public ackvar SizeX { get { return GetVar(32); } set { SetVar(32, value); } }

public ackvar SizeY { get { return GetVar(36); } set { SetVar(36, value); } }

public Vector Position { get { return GetVector(40); } set { SetVector(40, value); } }
public ackvar X { get { return GetVar(40); } set { SetVar(40, value); } }
public ackvar Y { get { return GetVar(44); } set { SetVar(44, value); } }
public ackvar Z { get { return GetVar(48); } set { SetVar(48, value); } }

public Angle Rotation { get { return GetAngle(52); } set { SetAngle(52, value); } }
public ackvar Pan { get { return GetVar(52); } set { SetVar(52, value); } }
public ackvar Tilt { get { return GetVar(56); } set { SetVar(56, value); } }
public ackvar Roll { get { return GetVar(60); } set { SetVar(60, value); } }

public ackvar OffsetX { get { return GetVar(64); } set { SetVar(64, value); } }

public ackvar OffsetY { get { return GetVar(68); } set { SetVar(68, value); } }

public ackvar Arc { get { return GetVar(72); } set { SetVar(72, value); } }

public ackvar Aspect { get { return GetVar(76); } set { SetVar(76, value); } }

public ackvar Ambient { get { return GetVar(80); } set { SetVar(80, value); } }

public ackvar Background { get { return GetVar(84); } set { SetVar(84, value); } }

public ackvar Alpha { get { return GetVar(88); } set { SetVar(88, value); } }

public Vector Portal { get { return GetVector(92); } set { SetVector(92, value); } }
public ackvar PortalX { get { return GetVar(92); } set { SetVar(92, value); } }
public ackvar PortalY { get { return GetVar(96); } set { SetVar(96, value); } }
public ackvar PortalZ { get { return GetVar(100); } set { SetVar(100, value); } }

public Vector PortalNormal { get { return GetVector(104); } set { SetVector(104, value); } }
public ackvar PNormalX { get { return GetVar(104); } set { SetVar(104, value); } }
public ackvar PNormalY { get { return GetVar(108); } set { SetVar(108, value); } }
public ackvar PNormalZ { get { return GetVar(112); } set { SetVar(112, value); } }

public ackvar FogStart { get { return GetVar(116); } set { SetVar(116, value); } }

public ackvar FogEnd { get { return GetVar(120); } set { SetVar(120, value); } }

public ackvar Depth { get { return GetVar(124); } set { SetVar(124, value); } }

public Entity Genius { get { return Get<Entity>(128); } set { Set(128, value); } }

public View PortalView { get { return Get<View>(132); } set { Set(132, value); } }

public Bitmap Target0 { get { return Get<Bitmap>(136); } set { Set(136, value); } }

public ackvar ClipNear { get { return GetVar(140); } set { SetVar(140, value); } }

public ackvar ClipFar { get { return GetVar(144); } set { SetVar(144, value); } }

public Material Material { get { return Get<Material>(148); } set { Set(148, value); } }

public View Stage { get { return Get<View>(152); } set { Set(152, value); } }

public ackvar SkillX { get { return GetVar(160); } set { SetVar(160, value); } }

public ackvar SkillY { get { return GetVar(164); } set { SetVar(164, value); } }

public ackvar LOD { get { return GetVar(168); } set { SetVar(168, value); } }

public ackvar Left { get { return GetVar(172); } set { SetVar(172, value); } }

public ackvar Right { get { return GetVar(176); } set { SetVar(176, value); } }

public ackvar Bottom { get { return GetVar(180); } set { SetVar(180, value); } }

public ackvar Top { get { return GetVar(184); } set { SetVar(184, value); } }

public Bitmap Target1 { get { return Get<Bitmap>(188); } set { Set(188, value); } }

public Bitmap Target2 { get { return Get<Bitmap>(192); } set { Set(192, value); } }

public Bitmap Target3 { get { return Get<Bitmap>(196); } set { Set(196, value); } }
}
}
