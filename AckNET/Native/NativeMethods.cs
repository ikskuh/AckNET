using System;
using System.Runtime.InteropServices;
namespace AckNET.Native
{
	public static class NativeMethods
	{
		[DllImport("acknex.dll", EntryPoint="ang", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Ang(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="sign", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Sign(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="fraction", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Fraction(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="integer", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Integer(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="floorv", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Floorv(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="random", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Random(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="randomize", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Randomize();

		[DllImport("acknex.dll", EntryPoint="random_seed", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar RandomSeed(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="absv", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Absv(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="sinv", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Sinv(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="cosv", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Cosv(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="tanv", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Tanv(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="asinv", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Asinv(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="acosv", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Acosv(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="atanv", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Atanv(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="atan2v", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Atan2v(ackvar param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="expv", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Expv(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="logv", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Logv(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="log10v", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Log10v(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="sqrtv", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Sqrtv(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="powv", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Powv(ackvar param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="maxv", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Maxv(ackvar param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="minv", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Minv(ackvar param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="fsin", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Fsin(ackvar param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="fcos", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Fcos(ackvar param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="ftan", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Ftan(ackvar param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="fasin", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Fasin(ackvar param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="facos", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Facos(ackvar param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="fatan", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Fatan(ackvar param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="accelerate", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Accelerate(ref ackvar param0, ackvar param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="clamp", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Clamp(ackvar param0, ackvar param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="cycle", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Cycle(ackvar param0, ackvar param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="smooth", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Smooth(ref ackvar param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="floatv", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Floatv(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="floatd", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Floatd(ackvar param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="floatr", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Floatr(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="ang_add", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		[return : MarshalAs(UnmanagedType.LPStruct)]
		public static extern Angle AngAdd(ref Angle param0, ref Angle param1);

		[DllImport("acknex.dll", EntryPoint="ang_rotate", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		[return : MarshalAs(UnmanagedType.LPStruct)]
		public static extern Angle AngRotate(ref Angle param0, ref Angle param1);

		[DllImport("acknex.dll", EntryPoint="ang_diff", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		[return : MarshalAs(UnmanagedType.LPStruct)]
		public static extern Angle AngDiff(ref Angle param0, ref Angle param1, ref Angle param2);

		[DllImport("acknex.dll", EntryPoint="ang_for_axis", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		[return : MarshalAs(UnmanagedType.LPStruct)]
		public static extern Angle AngForAxis(ref Angle param0, ref Vector param1, ackvar param2);

		// TODO: Implement matrix

		//[DllImport("acknex.dll", EntryPoint="ang_for_matrix", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//[return : MarshalAs(UnmanagedType.LPStruct)]
		//public static extern Angle AngForMatrix(ref Angle param0, float* param1);

		//[DllImport("acknex.dll", EntryPoint="ang_to_matrix", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern float* AngToMatrix(ref Angle param0, float* param1);

		[DllImport("acknex.dll", EntryPoint="vec_length", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar VecLength(ref Vector param0);

		[DllImport("acknex.dll", EntryPoint="vec_dist", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar VecDist(ref Vector param0, ref Vector param1);

		[DllImport("acknex.dll", EntryPoint="vec_cross", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar VecCross(ref Vector param0, ref Vector param1, ref Vector param2);

		[DllImport("acknex.dll", EntryPoint="vec_dot", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar VecDot(ref Vector param0, ref Vector param1);

		[DllImport("acknex.dll", EntryPoint="vec_mul", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		[return : MarshalAs(UnmanagedType.LPStruct)]
		public static extern Vector VecMul(ref Vector param0, ref Vector param1);

		[DllImport("acknex.dll", EntryPoint="vec_normalize", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		[return : MarshalAs(UnmanagedType.LPStruct)]
		public static extern Vector VecNormalize(ref Vector param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="vec_accelerate", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		[return : MarshalAs(UnmanagedType.LPStruct)]
		public static extern Vector VecAccelerate(ref Vector param0, ref Vector param1, ref Vector param2, ackvar param3);

		[DllImport("acknex.dll", EntryPoint="vec_bounce", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		[return : MarshalAs(UnmanagedType.LPStruct)]
		public static extern Vector VecBounce(ref Vector param0, ref Vector param1);

		[DllImport("acknex.dll", EntryPoint="vec_add", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		[return : MarshalAs(UnmanagedType.LPStruct)]
		public static extern Vector VecAdd(ref Vector param0, ref Vector param1);

		[DllImport("acknex.dll", EntryPoint="vec_diff", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		[return : MarshalAs(UnmanagedType.LPStruct)]
		public static extern Vector VecDiff(ref Vector param0, ref Vector param1, ref Vector param2);

		[DllImport("acknex.dll", EntryPoint="vec_inverse", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		[return : MarshalAs(UnmanagedType.LPStruct)]
		public static extern Vector VecInverse(ref Vector param0);

		[DllImport("acknex.dll", EntryPoint="vec_lerp", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		[return : MarshalAs(UnmanagedType.LPStruct)]
		public static extern Vector VecLerp(ref Vector param0, ref Vector param1, ref Vector param2, ackvar param3);

		[DllImport("acknex.dll", EntryPoint="vec_rotate", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		[return : MarshalAs(UnmanagedType.LPStruct)]
		public static extern Vector VecRotate(ref Vector param0, ref Angle param1);

		[DllImport("acknex.dll", EntryPoint="vec_rotateback", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		[return : MarshalAs(UnmanagedType.LPStruct)]
		public static extern Vector VecRotateback(ref Vector param0, ref Angle param1);

		[DllImport("acknex.dll", EntryPoint="vec_rotateaxis", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		[return : MarshalAs(UnmanagedType.LPStruct)]
		public static extern Vector VecRotateaxis(ref Vector param0, ref Vector param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="vec_scale", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		[return : MarshalAs(UnmanagedType.LPStruct)]
		public static extern Vector VecScale(ref Vector param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="vec_set", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		[return : MarshalAs(UnmanagedType.LPStruct)]
		public static extern Vector VecSet(ref Vector param0, ref Vector param1);

		[DllImport("acknex.dll", EntryPoint="vec_fill", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		[return : MarshalAs(UnmanagedType.LPStruct)]
		public static extern Vector VecFill(ref Vector param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="vec_sub", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		[return : MarshalAs(UnmanagedType.LPStruct)]
		public static extern Vector VecSub(ref Vector param0, ref Vector param1);

		[DllImport("acknex.dll", EntryPoint="vec_for_angle", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		[return : MarshalAs(UnmanagedType.LPStruct)]
		public static extern Vector VecForAngle(ref Vector param0, ref Angle param1);

		[DllImport("acknex.dll", EntryPoint="vec_to_angle", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar VecToAngle(ref Angle param0, ref Vector param1);

		[DllImport("acknex.dll", EntryPoint="vec_for_bone", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		[return : MarshalAs(UnmanagedType.LPStruct)]
		public static extern Vector VecForBone(ref Vector param0, IntPtr param1, string param2);

		[DllImport("acknex.dll", EntryPoint="ang_for_bone", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		[return : MarshalAs(UnmanagedType.LPStruct)]
		public static extern Angle AngForBone(ref Angle param0, IntPtr param1, string param2);

		[DllImport("acknex.dll", EntryPoint="vec_for_normal", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		[return : MarshalAs(UnmanagedType.LPStruct)]
		public static extern Vector VecForNormal(ref Vector param0, IntPtr param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="vec_for_vertex", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		[return : MarshalAs(UnmanagedType.LPStruct)]
		public static extern Vector VecForVertex(ref Vector param0, IntPtr param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="vec_for_ent", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		[return : MarshalAs(UnmanagedType.LPStruct)]
		public static extern Vector VecForEnt(ref Vector param0, IntPtr param1);

		[DllImport("acknex.dll", EntryPoint="vec_to_ent", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		[return : MarshalAs(UnmanagedType.LPStruct)]
		public static extern Vector VecToEnt(ref Vector param0, IntPtr param1);

		[DllImport("acknex.dll", EntryPoint="vec_for_min", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		[return : MarshalAs(UnmanagedType.LPStruct)]
		public static extern Vector VecForMin(ref Vector param0, IntPtr param1);

		[DllImport("acknex.dll", EntryPoint="vec_for_max", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		[return : MarshalAs(UnmanagedType.LPStruct)]
		public static extern Vector VecForMax(ref Vector param0, IntPtr param1);

		[DllImport("acknex.dll", EntryPoint="vec_for_mesh", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		[return : MarshalAs(UnmanagedType.LPStruct)]
		public static extern Vector VecForMesh(ref Vector param0, IntPtr param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="vec_to_mesh", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		[return : MarshalAs(UnmanagedType.LPStruct)]
		public static extern Vector VecToMesh(ref Vector param0, IntPtr param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="vec_for_uv", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		[return : MarshalAs(UnmanagedType.LPStruct)]
		public static extern Vector VecForUv(ref Vector param0, IntPtr param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="vec_to_uv", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		[return : MarshalAs(UnmanagedType.LPStruct)]
		public static extern Vector VecToUv(ref Vector param0, IntPtr param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="vec_for_screen", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		[return : MarshalAs(UnmanagedType.LPStruct)]
		public static extern Vector VecForScreen(ref Vector param0, IntPtr param1);

		[DllImport("acknex.dll", EntryPoint="vec_to_screen", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		[return : MarshalAs(UnmanagedType.LPStruct)]
		public static extern Vector VecToScreen(ref Vector param0, IntPtr param1);

		[DllImport("acknex.dll", EntryPoint="rel_for_screen", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		[return : MarshalAs(UnmanagedType.LPStruct)]
		public static extern Vector RelForScreen(ref Vector param0, IntPtr param1);

		[DllImport("acknex.dll", EntryPoint="rel_to_screen", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		[return : MarshalAs(UnmanagedType.LPStruct)]
		public static extern Vector RelToScreen(ref Vector param0, IntPtr param1);

		// Not that it is TOTALLY unnecessary in C#
		//[DllImport("acknex.dll", EntryPoint="vector", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//[return : MarshalAs(UnmanagedType.LPStruct)]
		//public static extern Vector Vector(ackvar param0, ackvar param1, ackvar param2);

		// TODO: Implement matrix
		//[DllImport("acknex.dll", EntryPoint="mat_identity", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern float* MatIdentity(float* param0);

		//[DllImport("acknex.dll", EntryPoint="mat_inverse", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern float* MatInverse(float* param0, float* param1);

		//[DllImport("acknex.dll", EntryPoint="mat_multiply", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern float* MatMultiply(float* param0, float* param1);

		//[DllImport("acknex.dll", EntryPoint="mat_scale", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern float* MatScale(float* param0, ackvar param1, ackvar param2, ackvar param3);

		//[DllImport("acknex.dll", EntryPoint="mat_set", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern float* MatSet(float* param0, float* param1);

		//[DllImport("acknex.dll", EntryPoint="mat_transpose", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern float* MatTranspose(float* param0, float* param1);

		[DllImport("acknex.dll", EntryPoint="str_create", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr StrCreate(string param0);

		// TODO: Implement wide strings
		//[DllImport("acknex.dll", EntryPoint="str_createw", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern IntPtr StrCreatew(short* param0);

		[DllImport("acknex.dll", EntryPoint="str_remove", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar StrRemove(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint = "str_cpy", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern IntPtr StrCpy(IntPtr param0, string param1);

		//[DllImport("acknex.dll", EntryPoint="str_cat", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern IntPtr StrCat(IntPtr param0, string param1);

		//[DllImport("acknex.dll", EntryPoint="str_cat_num", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern IntPtr StrCatNum(IntPtr param0, string param1, ackvar param2);

		//[DllImport("acknex.dll", EntryPoint="str_printf", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern IntPtr StrPrintf(IntPtr param0, string param1, ... param2);

		//[DllImport("acknex.dll", EntryPoint="str_clip", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern IntPtr StrClip(IntPtr param0, ackvar param1);

		//[DllImport("acknex.dll", EntryPoint="str_trunc", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern IntPtr StrTrunc(IntPtr param0, ackvar param1);

		//[DllImport("acknex.dll", EntryPoint="str_lwr", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern IntPtr StrLwr(IntPtr param0);

		//[DllImport("acknex.dll", EntryPoint="str_upr", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern IntPtr StrUpr(IntPtr param0);

		//[DllImport("acknex.dll", EntryPoint="str_cmp", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern ackvar StrCmp(IntPtr param0, string param1);

		//[DllImport("acknex.dll", EntryPoint="str_cmpi", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern ackvar StrCmpi(IntPtr param0, string param1);

		//[DllImport("acknex.dll", EntryPoint="str_cmpni", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern ackvar StrCmpni(IntPtr param0, string param1);

		//[DllImport("acknex.dll", EntryPoint="str_len", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern ackvar StrLen(string param0);

		//[DllImport("acknex.dll", EntryPoint="str_chr", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern ackvar StrChr(IntPtr param0, ackvar param1, ackvar param2);

		//[DllImport("acknex.dll", EntryPoint="str_setchr", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern ackvar StrSetchr(IntPtr param0, ackvar param1, ackvar param2);

		//[DllImport("acknex.dll", EntryPoint="str_getchr", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern ackvar StrGetchr(IntPtr param0, ackvar param1);

		//[DllImport("acknex.dll", EntryPoint="str_stri", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern ackvar StrStri(IntPtr param0, string param1);

		//[DllImport("acknex.dll", EntryPoint="str_for_asc", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern IntPtr StrForAsc(IntPtr param0, ackvar param1);

		//[DllImport("acknex.dll", EntryPoint="str_to_asc", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern ackvar StrToAsc(string param0);

		//[DllImport("acknex.dll", EntryPoint="str_for_float", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern IntPtr StrForFloat(IntPtr param0, double param1);

		//[DllImport("acknex.dll", EntryPoint="str_for_int", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern IntPtr StrForInt(IntPtr param0, long param1);

		//[DllImport("acknex.dll", EntryPoint="str_for_num", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern IntPtr StrForNum(IntPtr param0, ackvar param1);

		//[DllImport("acknex.dll", EntryPoint="str_to_float", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern double StrToFloat(string param0);

		//[DllImport("acknex.dll", EntryPoint="str_to_int", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern long StrToInt(string param0);

		//[DllImport("acknex.dll", EntryPoint="str_to_num", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern ackvar StrToNum(string param0);

		//[DllImport("acknex.dll", EntryPoint="str_cursor", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern ackvar StrCursor(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="str_width", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar StrWidth(string param0, IntPtr param1);

		[DllImport("acknex.dll", EntryPoint="str_for_entname", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr StrForEntname(IntPtr param0, IntPtr param1);

		[DllImport("acknex.dll", EntryPoint="str_for_entfile", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr StrForEntfile(IntPtr param0, IntPtr param1);

		[DllImport("acknex.dll", EntryPoint="str_for_id", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr StrForId(IntPtr param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="bmap_create", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr BmapCreate(string param0);

		[DllImport("acknex.dll", EntryPoint="bmap_createblack", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr BmapCreateblack(ackvar param0, ackvar param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="bmap_createpart", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr BmapCreatepart(string param0, ackvar param1, ackvar param2, ackvar param3, ackvar param4);

		[DllImport("acknex.dll", EntryPoint="bmap_remove", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern void BmapRemove(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="bmap_for_entity", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr BmapForEntity(IntPtr param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="bmap_for_screen", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr BmapForScreen(IntPtr param0, ackvar param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="bmap_for_buffer", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr BmapForBuffer(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="bmap_for_texture", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr BmapForTexture(string param0);

		[DllImport("acknex.dll", EntryPoint="bmap_preload", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr BmapPreload(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="bmap_purge", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr BmapPurge(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="bmap_load", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr BmapLoad(IntPtr param0, string param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="bmap_save", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr BmapSave(IntPtr param0, string param1);

		[DllImport("acknex.dll", EntryPoint="bmap_to_alpha", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr BmapToAlpha(IntPtr param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="bmap_to_cubemap", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr BmapToCubemap(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="bmap_to_mipmap", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr BmapToMipmap(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="bmap_to_normals", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr BmapToNormals(IntPtr param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="bmap_to_uv", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr BmapToUv(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="bmap_to_format", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr BmapToFormat(IntPtr param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="bmap_height", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar BmapHeight(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="bmap_width", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar BmapWidth(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="bmap_format", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar BmapFormat(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="bmap_lock", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar BmapLock(IntPtr param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="bmap_unlock", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar BmapUnlock(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="bmap_blit", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar BmapBlit(IntPtr param0, IntPtr param1, ref Vector param2, ref Vector param3);

		[DllImport("acknex.dll", EntryPoint="bmap_blitpart", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar BmapBlitpart(IntPtr param0, IntPtr param1, ref Vector param2, ref Vector param3, ref Vector param4, ref Vector param5);

		[DllImport("acknex.dll", EntryPoint="bmap_fill", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr BmapFill(IntPtr param0, ref Color param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="bmap_process", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr BmapProcess(IntPtr param0, IntPtr param1, IntPtr param2);

		[DllImport("acknex.dll", EntryPoint="bmap_rendertarget", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar BmapRendertarget(IntPtr param0, ackvar param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="bmap_zbuffer", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar BmapZbuffer(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="pixel_for_bmap", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar PixelForBmap(IntPtr param0, ackvar param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="pixel_to_bmap", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar PixelToBmap(IntPtr param0, ackvar param1, ackvar param2, ackvar param3);

		[DllImport("acknex.dll", EntryPoint="pixel_for_vec", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar PixelForVec(ref Color param0, ackvar param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="pixel_to_vec", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		[return : MarshalAs(UnmanagedType.LPStruct)]
		public static extern Color PixelToVec(ref Color param0, ref ackvar param1, ackvar param2, ackvar param3);

		[DllImport("acknex.dll", EntryPoint="cd_play", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar CdPlay(ackvar param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="cd_pause", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar CdPause();

		[DllImport("acknex.dll", EntryPoint="cd_start", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar CdStart();

		[DllImport("acknex.dll", EntryPoint="cd_track", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar CdTrack();

		[DllImport("acknex.dll", EntryPoint="media_play", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar MediaPlay(string param0, IntPtr param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="media_loop", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar MediaLoop(string param0, IntPtr param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="media_pause", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar MediaPause(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="media_playing", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar MediaPlaying(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="media_start", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar MediaStart(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="media_stop", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar MediaStop(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="media_tune", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar MediaTune(ackvar param0, ackvar param1, ackvar param2, ackvar param3);

		[DllImport("acknex.dll", EntryPoint="snd_create", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr SndCreate(string param0);

		[DllImport("acknex.dll", EntryPoint="snd_remove", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar SndRemove(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="snd_buffer", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar SndBuffer(IntPtr param0, IntPtr param1, IntPtr param2);

		[DllImport("acknex.dll", EntryPoint="snd_play", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar SndPlay(IntPtr param0, ackvar param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="snd_loop", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar SndLoop(IntPtr param0, ackvar param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="snd_playing", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar SndPlaying(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="snd_pause", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar SndPause(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="snd_start", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar SndStart(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="snd_stop", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar SndStop(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="snd_tune", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar SndTune(ackvar param0, ackvar param1, ackvar param2, ackvar param3);

		[DllImport("acknex.dll", EntryPoint="snd_add", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar SndAdd(ackvar param0, ackvar param1, IntPtr param2, ackvar param3);

		[DllImport("acknex.dll", EntryPoint="snd_stopall", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar SndStopall(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="ent_playloop", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar EntPlayloop(IntPtr param0, IntPtr param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="ent_playloop2", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar EntPlayloop2(IntPtr param0, IntPtr param1, ackvar param2, ackvar param3);

		[DllImport("acknex.dll", EntryPoint="ent_playsound", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar EntPlaysound(IntPtr param0, IntPtr param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="ent_playsound2", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar EntPlaysound2(IntPtr param0, IntPtr param1, ackvar param2, ackvar param3);

		[DllImport("acknex.dll", EntryPoint="c_intersect", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar CIntersect(ref Vector param0, ref Vector param1, ref Vector param2, ref Vector param3, ref Vector param4, ref Vector param5);

		[DllImport("acknex.dll", EntryPoint="c_content", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar CContent(ref Vector param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="c_scan", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar CScan(ref Vector param0, ref Vector param1, ref Vector param2, ackvar param3);

		[DllImport("acknex.dll", EntryPoint="c_trace", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar CTrace(ref Vector param0, ref Vector param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="c_move", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar CMove(IntPtr param0, ref Vector param1, ref Vector param2, ackvar param3);

		[DllImport("acknex.dll", EntryPoint="c_rotate", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar CRotate(IntPtr param0, ref Vector param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="c_setminmax", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar CSetminmax(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="c_updatehull", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar CUpdatehull(IntPtr param0, ackvar param1);

		// TODO: c_ignore
		//[DllImport("acknex.dll", EntryPoint="c_ignore", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern ackvar CIgnore(ackvar param0, ... param1);

		[DllImport("acknex.dll", EntryPoint="mtl_create", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr MtlCreate();

		[DllImport("acknex.dll", EntryPoint="mtl_remove", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern void MtlRemove(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="effect", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Effect(IntPtr param0, ackvar param1, ref Vector param2, ref Vector param3);

		[DllImport("acknex.dll", EntryPoint="effect_layer", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar EffectLayer(IntPtr param0, ackvar param1, ref Vector param2, ref Vector param3);

		[DllImport("acknex.dll", EntryPoint="effect_local", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar EffectLocal(IntPtr param0, ackvar param1, ref Vector param2, ref Vector param3);

		[DllImport("acknex.dll", EntryPoint="effect_cpy", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr EffectCpy(IntPtr param0, IntPtr param1);

		[DllImport("acknex.dll", EntryPoint="effect_load", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr EffectLoad(IntPtr param0, string param1);

		// TODO: Implement matrix
		//[DllImport("acknex.dll", EntryPoint="mat_effect", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern ackvar MatEffect(float* param0);

		[DllImport("acknex.dll", EntryPoint="ent_create", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr EntCreate(string param0, ref Vector param1, IntPtr param2);

		[DllImport("acknex.dll", EntryPoint="ent_createlocal", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr EntCreatelocal(string param0, ref Vector param1, IntPtr param2);

		[DllImport("acknex.dll", EntryPoint="ent_createlayer", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr EntCreatelayer(string param0, ackvar param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="ent_createterrain", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr EntCreateterrain(IntPtr param0, ref Vector param1, ackvar param2, ackvar param3, ackvar param4);

		[DllImport("acknex.dll", EntryPoint="ent_next", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr EntNext(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="ent_nextlight", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr EntNextlight(IntPtr param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="ent_nextvertex", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar EntNextvertex(IntPtr param0, ref Vector param1);

		[DllImport("acknex.dll", EntryPoint="ent_pvs", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr EntPvs(ackvar param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="ent_for_name", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr EntForName(string param0);

		[DllImport("acknex.dll", EntryPoint="ent_for_file", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr EntForFile(string param0);

		[DllImport("acknex.dll", EntryPoint="ent_mesh", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr EntMesh(IntPtr param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="ent_getmesh", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr EntGetmesh(IntPtr param0, ackvar param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="ent_setmesh", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar EntSetmesh(IntPtr param0, IntPtr param1, ackvar param2, ackvar param3);

		[DllImport("acknex.dll", EntryPoint="ent_buffers", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar EntBuffers(IntPtr param0, ackvar param1, ackvar param2, IntPtr param3, IntPtr param4, IntPtr param5);

		[DllImport("acknex.dll", EntryPoint="ent_getvertex", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr EntGetvertex(IntPtr param0, IntPtr param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="ent_setvertex", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr EntSetvertex(IntPtr param0, IntPtr param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="ent_decal", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr EntDecal(IntPtr param0, IntPtr param1, ackvar param2, ackvar param3);

		[DllImport("acknex.dll", EntryPoint="ent_getdecal", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr EntGetdecal(IntPtr param0, ackvar param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="ent_clone", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr EntClone(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="ent_cloneskin", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr EntCloneskin(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="ent_morph", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar EntMorph(IntPtr param0, string param1);

		[DllImport("acknex.dll", EntryPoint="ent_morphskin", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar EntMorphskin(IntPtr param0, string param1);

		[DllImport("acknex.dll", EntryPoint="ent_mtlset", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr EntMtlset(IntPtr param0, IntPtr param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="ent_getskin", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr EntGetskin(IntPtr param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="ent_setskin", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr EntSetskin(IntPtr param0, IntPtr param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="ent_preload", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar EntPreload(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="ent_purge", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar EntPurge(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="ent_reload", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar EntReload(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="ent_remove", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar EntRemove(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="ent_animate", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar EntAnimate(IntPtr param0, string param1, ackvar param2, ackvar param3);

		[DllImport("acknex.dll", EntryPoint="ent_animatefrom", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar EntAnimatefrom(IntPtr param0, IntPtr param1, string param2, ackvar param3, ackvar param4);

		[DllImport("acknex.dll", EntryPoint="ent_blend", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar EntBlend(IntPtr param0, ackvar param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="ent_blendframe", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar EntBlendframe(IntPtr param0, IntPtr param1, string param2, ackvar param3, ackvar param4);

		[DllImport("acknex.dll", EntryPoint="ent_blendpose", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar EntBlendpose(IntPtr param0, ackvar param1, ackvar param2, ackvar param3);

		[DllImport("acknex.dll", EntryPoint="ent_bonename", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr EntBonename(IntPtr param0, IntPtr param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="ent_bonereset_all", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar EntBoneresetAll(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="ent_bonereset", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar EntBonereset(IntPtr param0, string param1);

		[DllImport("acknex.dll", EntryPoint="ent_bonereset_branch", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar EntBoneresetBranch(IntPtr param0, string param1);

		[DllImport("acknex.dll", EntryPoint="ent_bonerotate", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar EntBonerotate(IntPtr param0, string param1, ref Vector param2);

		[DllImport("acknex.dll", EntryPoint="ent_bonerotate_parent", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar EntBonerotateParent(IntPtr param0, string param1, ref Vector param2);

		[DllImport("acknex.dll", EntryPoint="ent_bonemove", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar EntBonemove(IntPtr param0, string param1, ref Vector param2);

		[DllImport("acknex.dll", EntryPoint="ent_bonescale", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar EntBonescale(IntPtr param0, string param1, ref Vector param2);

		[DllImport("acknex.dll", EntryPoint="ent_bonehandle", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern long EntBonehandle(IntPtr param0, string param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="ent_boneparent", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern long EntBoneparent(IntPtr param0, string param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="ent_fixnormals", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar EntFixnormals(IntPtr param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="ent_type", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar EntType(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="ent_status", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar EntStatus(IntPtr param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="ent_frames", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar EntFrames(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="ent_skins", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar EntSkins(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="ent_bones", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar EntBones(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="ent_vertices", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar EntVertices(IntPtr param0);

		// TODO: Implement path
		//[DllImport("acknex.dll", EntryPoint="path_create", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern ackvar PathCreate(IntPtr param0, ackvar param1, ackvar param2);

		//[DllImport("acknex.dll", EntryPoint="path_set", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern ackvar PathSet(IntPtr param0, string param1);

		//[DllImport("acknex.dll", EntryPoint="path_next", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern ackvar PathNext(IntPtr param0);

		//[DllImport("acknex.dll", EntryPoint="path_getedge", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern var* PathGetedge(IntPtr param0, ackvar param1, ackvar param2, ref ackvar param3);

		//[DllImport("acknex.dll", EntryPoint="path_setedge", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern var* PathSetedge(IntPtr param0, ackvar param1, ackvar param2, ref ackvar param3);

		//[DllImport("acknex.dll", EntryPoint="path_getnode", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern var* PathGetnode(IntPtr param0, ackvar param1, ref Vector param2, ref ackvar param3);

		//[DllImport("acknex.dll", EntryPoint="path_setnode", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern var* PathSetnode(IntPtr param0, ackvar param1, ref Vector param2, ref ackvar param3);

		//[DllImport("acknex.dll", EntryPoint="path_nextnode", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern ackvar PathNextnode(IntPtr param0, ackvar param1, ackvar param2);

		//[DllImport("acknex.dll", EntryPoint="path_scan", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern ackvar PathScan(IntPtr param0, ref Vector param1, ref Angle param2, ref Vector param3);

		//[DllImport("acknex.dll", EntryPoint="path_scanpath", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern ackvar PathScanpath(IntPtr param0, ref Vector param1, ref Angle param2, ref Vector param3);

		//[DllImport("acknex.dll", EntryPoint="path_scannode", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern ackvar PathScannode(IntPtr param0, ackvar param1);

		//[DllImport("acknex.dll", EntryPoint="path_length", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern ackvar PathLength(IntPtr param0);

		//[DllImport("acknex.dll", EntryPoint="path_spline", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern ackvar PathSpline(IntPtr param0, ref Vector param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="region_check", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar RegionCheck(string param0, ref Vector param1, ref Vector param2);

		[DllImport("acknex.dll", EntryPoint="region_create", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar RegionCreate(string param0, ref Vector param1, ref Vector param2);

		[DllImport("acknex.dll", EntryPoint="region_find", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr RegionFind(IntPtr param0, ref Vector param1);

		[DllImport("acknex.dll", EntryPoint="region_set", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar RegionSet(string param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="region_get", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar RegionGet(string param0, ackvar param1, ref Vector param2, ref Vector param3);

		[DllImport("acknex.dll", EntryPoint="file_cpy", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern string FileCpy(string param0, string param1);

		[DllImport("acknex.dll", EntryPoint="file_rename", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern string FileRename(string param0, string param1);

		[DllImport("acknex.dll", EntryPoint="file_for_screen", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern string FileForScreen(string param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="file_date", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern long FileDate(string param0);

		[DllImport("acknex.dll", EntryPoint="file_delete", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern string FileDelete(string param0);

		[DllImport("acknex.dll", EntryPoint="file_exists", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr FileExists(string param0);

		[DllImport("acknex.dll", EntryPoint="file_load", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr FileLoad(string param0, IntPtr param1, ref int param2);

		[DllImport("acknex.dll", EntryPoint="file_save", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr FileSave(string param0, IntPtr param1, long param2);

		[DllImport("acknex.dll", EntryPoint="file_open_append", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar FileOpenAppend(string param0);

		[DllImport("acknex.dll", EntryPoint="file_open_game", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar FileOpenGame(string param0);

		[DllImport("acknex.dll", EntryPoint="file_open_read", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar FileOpenRead(string param0);

		[DllImport("acknex.dll", EntryPoint="file_open_write", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar FileOpenWrite(string param0);

		[DllImport("acknex.dll", EntryPoint="file_close", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar FileClose(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="file_length", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar FileLength(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="file_find", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar FileFind(ackvar param0, string param1);

		[DllImport("acknex.dll", EntryPoint="file_seek", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar FileSeek(ackvar param0, ackvar param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="file_asc_read", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar FileAscRead(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="file_asc_write", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar FileAscWrite(ackvar param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="file_chr_read", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar FileChrRead(ackvar param0, IntPtr param1);

		[DllImport("acknex.dll", EntryPoint="file_str_read", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar FileStrRead(ackvar param0, IntPtr param1);

		[DllImport("acknex.dll", EntryPoint="file_str_readto", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar FileStrReadto(ackvar param0, IntPtr param1, string param2, ackvar param3);

		[DllImport("acknex.dll", EntryPoint="file_str_readtow", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar FileStrReadtow(ackvar param0, IntPtr param1, string param2, ackvar param3);

		[DllImport("acknex.dll", EntryPoint="file_str_write", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar FileStrWrite(ackvar param0, string param1);

		[DllImport("acknex.dll", EntryPoint="file_str_writeto", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar FileStrWriteto(ackvar param0, string param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="file_var_read", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar FileVarRead(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="file_var_write", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar FileVarWrite(ackvar param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="key_for_str", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar KeyForStr(string param0);

		[DllImport("acknex.dll", EntryPoint="str_for_key", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr StrForKey(IntPtr param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="key_pressed", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar KeyPressed(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="key_set", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar KeySet(ackvar param0, IntPtr param1);

		[DllImport("acknex.dll", EntryPoint="level_load", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar LevelLoad(string param0);

		[DllImport("acknex.dll", EntryPoint="level_mark", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern void LevelMark();

		[DllImport("acknex.dll", EntryPoint="level_free", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern void LevelFree();

		[DllImport("acknex.dll", EntryPoint="game_save", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar GameSave(string param0, ackvar param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="game_load", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar GameLoad(string param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="sys_active", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern long SysActive(string param0);

		[DllImport("acknex.dll", EntryPoint="sys_exit", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar SysExit(string param0);

		[DllImport("acknex.dll", EntryPoint="sys_message", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar SysMessage(string param0);

		[DllImport("acknex.dll", EntryPoint="sys_metrics", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar SysMetrics(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="sys_record", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar SysRecord(string param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="sys_replay", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar SysReplay(string param0);

		[DllImport("acknex.dll", EntryPoint="sys_trial", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar SysTrial(string param0, string param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="sys_setstr", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar SysSetstr(string param0, string param1, string param2);

		[DllImport("acknex.dll", EntryPoint="sys_getstr", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr SysGetstr(string param0, string param1, string param2);

		[DllImport("acknex.dll", EntryPoint="sys_setvar", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar SysSetvar(string param0, string param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="sys_getvar", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar SysGetvar(string param0, string param1);

		[DllImport("acknex.dll", EntryPoint="video_set", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar VideoSet(ackvar param0, ackvar param1, ackvar param2, ackvar param3);

		[DllImport("acknex.dll", EntryPoint="video_switch", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar VideoSwitch(ackvar param0, ackvar param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="video_window", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar VideoWindow(ref Vector param0, ref Vector param1, ackvar param2, string param3);

		[DllImport("acknex.dll", EntryPoint="video_border", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar VideoBorder(IntPtr param0, ackvar param1, ackvar param2, ackvar param3, ackvar param4);

		[DllImport("acknex.dll", EntryPoint="pan_create", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr PanCreate(string param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="pan_remove", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar PanRemove(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="pan_setbmap", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar PanSetbmap(IntPtr param0, ackvar param1, ackvar param2, IntPtr param3);

		[DllImport("acknex.dll", EntryPoint="pan_setcolor", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar PanSetcolor(IntPtr param0, ackvar param1, ackvar param2, ref Color param3);

		[DllImport("acknex.dll", EntryPoint="pan_setevent", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar PanSetevent(IntPtr param0, ackvar param1, ackvar param2, IntPtr param3);

		[DllImport("acknex.dll", EntryPoint="pan_setpos", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar PanSetpos(IntPtr param0, ackvar param1, ackvar param2, ref Vector param3);

		[DllImport("acknex.dll", EntryPoint="pan_getpos", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar PanGetpos(IntPtr param0, ackvar param1, ackvar param2, ref Vector param3);

		[DllImport("acknex.dll", EntryPoint="pan_setvar", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar PanSetvar(IntPtr param0, ackvar param1, ackvar param2, ref ackvar param3);

		[DllImport("acknex.dll", EntryPoint="pan_setbutton", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar PanSetbutton(IntPtr param0, ackvar param1, ackvar param2, ackvar param3, ackvar param4, IntPtr param5, IntPtr param6, IntPtr param7, IntPtr param8, IntPtr param9, IntPtr param10, IntPtr param11);

		[DllImport("acknex.dll", EntryPoint="pan_setdigits", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar PanSetdigits(IntPtr param0, ackvar param1, ackvar param2, ackvar param3, string param4, IntPtr param5, ackvar param6, ref ackvar param7);

		[DllImport("acknex.dll", EntryPoint="pan_setneedle", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar PanSetneedle(IntPtr param0, ackvar param1, ackvar param2, ackvar param3, IntPtr param4, ackvar param5, ackvar param6, ackvar param7, ackvar param8, ackvar param9, ref ackvar param10);

		[DllImport("acknex.dll", EntryPoint="pan_setslider", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar PanSetslider(IntPtr param0, ackvar param1, ackvar param2, ackvar param3, IntPtr param4, IntPtr param5, ackvar param6, ackvar param7, ref ackvar param8);

		[DllImport("acknex.dll", EntryPoint="pan_setstring", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar PanSetstring(IntPtr param0, ackvar param1, ackvar param2, ackvar param3, IntPtr param4, string param5);

		[DllImport("acknex.dll", EntryPoint="pan_setwindow", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar PanSetwindow(IntPtr param0, ackvar param1, ackvar param2, ackvar param3, ackvar param4, ackvar param5, IntPtr param6, ref ackvar param7, ref ackvar param8);

		[DllImport("acknex.dll", EntryPoint="digits_set", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar DigitsSet(IntPtr param0, ackvar param1, ref ackvar param2);

		[DllImport("acknex.dll", EntryPoint="button_state", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar ButtonState(IntPtr param0, ackvar param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="layer_sort", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar LayerSort(IntPtr param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="txt_create", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr TxtCreate(ackvar param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="txt_remove", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern void TxtRemove(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="txt_for_dir", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar TxtForDir(IntPtr param0, string param1);

		[DllImport("acknex.dll", EntryPoint="txt_sort", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar TxtSort(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="txt_load", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar TxtLoad(IntPtr param0, string param1);

		[DllImport("acknex.dll", EntryPoint="txt_loadw", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar TxtLoadw(IntPtr param0, string param1);

		[DllImport("acknex.dll", EntryPoint="txt_addstring", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar TxtAddstring(IntPtr param0, string param1);

		[DllImport("acknex.dll", EntryPoint="txt_setinvisible", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar TxtSetinvisible(IntPtr param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="txt_setvisible", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar TxtSetvisible(IntPtr param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="txt_str", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr TxtStr(IntPtr param0, int param1);

		[DllImport("acknex.dll", EntryPoint="font_create", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr FontCreate(string param0);

		[DllImport("acknex.dll", EntryPoint="font_remove", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern void FontRemove(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="view_create", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr ViewCreate(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="view_check", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar ViewCheck(IntPtr param0, ref Vector param1, ref Vector param2);

		[DllImport("acknex.dll", EntryPoint="view_to_light", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar ViewToLight(IntPtr param0, ackvar param1, ackvar param2);

		// TODO: Implement matrix
		//[DllImport("acknex.dll", EntryPoint="view_to_matrix", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern float* ViewToMatrix(IntPtr param0, float* param1, float* param2);

		//[DllImport("acknex.dll", EntryPoint="view_to_split", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		//public static extern float* ViewToSplit(IntPtr param0, ackvar param1, ackvar param2, IntPtr param3, float* param4);

		[DllImport("acknex.dll", EntryPoint="draw_begin", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr DrawBegin();

		[DllImport("acknex.dll", EntryPoint="draw_line", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar DrawLine(ref Vector param0, ref Color param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="draw_line3d", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar DrawLine3d(ref Vector param0, ref Color param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="draw_box3d", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar DrawBox3d(ref Vector param0, ref Vector param1, ref Color param2, ackvar param3);

		[DllImport("acknex.dll", EntryPoint="draw_obj", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar DrawObj(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="draw_point3d", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar DrawPoint3d(ref Vector param0, ref Color param1, ackvar param2, ackvar param3);

		[DllImport("acknex.dll", EntryPoint="draw_quad", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar DrawQuad(IntPtr param0, ref Vector param1, ref Vector param2, ref Vector param3, ref Vector param4, ref Color param5, ackvar param6, ackvar param7);

		[DllImport("acknex.dll", EntryPoint="draw_text", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar DrawText(string param0, ackvar param1, ackvar param2, ref Color param3);

		[DllImport("acknex.dll", EntryPoint="draw_textmode", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar DrawTextmode(string param0, ackvar param1, ackvar param2, ackvar param3);

		[DllImport("acknex.dll", EntryPoint="proc_client", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar ProcClient(IntPtr param0, IntPtr param1);

		[DllImport("acknex.dll", EntryPoint="proc_local", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar ProcLocal(IntPtr param0, IntPtr param1);

		[DllImport("acknex.dll", EntryPoint="send_data_to", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar SendDataTo(IntPtr param0, IntPtr param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="send_data_id", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar SendDataId(ackvar param0, IntPtr param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="send_skill", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar SendSkill(ref ackvar param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="send_skill_to", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar SendSkillTo(IntPtr param0, ref ackvar param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="send_skill_id", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar SendSkillId(ackvar param0, ref ackvar param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="send_string", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar SendString(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="send_string_to", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar SendStringTo(IntPtr param0, IntPtr param1);

		[DllImport("acknex.dll", EntryPoint="send_string_id", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar SendStringId(ackvar param0, IntPtr param1);

		[DllImport("acknex.dll", EntryPoint="send_var", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar SendVar(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="send_var_to", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar SendVarTo(IntPtr param0, IntPtr param1);

		[DllImport("acknex.dll", EntryPoint="send_var_id", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar SendVarId(ackvar param0, IntPtr param1);

		[DllImport("acknex.dll", EntryPoint="session_close", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern void SessionClose();

		[DllImport("acknex.dll", EntryPoint="session_connect", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar SessionConnect(string param0, string param1);

		[DllImport("acknex.dll", EntryPoint="session_open", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar SessionOpen(string param0);

		[DllImport("acknex.dll", EntryPoint="client_drop", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar ClientDrop(string param0);

		[DllImport("acknex.dll", EntryPoint="client_drop_id", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar ClientDropId(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="client_find", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar ClientFind(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="ent_sendnow", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar EntSendnow(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="socket_connect", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar SocketConnect(string param0, ackvar param1, ackvar param2);

		[DllImport("acknex.dll", EntryPoint="socket_select", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar SocketSelect(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="socket_receive", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar SocketReceive(IntPtr param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="socket_send", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar SocketSend(IntPtr param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="beep", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Beep();

		[DllImport("acknex.dll", EntryPoint="diag", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Diag(string param0);

		[DllImport("acknex.dll", EntryPoint="diag_var", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar DiagVar(string param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="diag_frame", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar DiagFrame(ref ackvar param0);

		[DllImport("acknex.dll", EntryPoint="diag_status", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar DiagStatus();

		[DllImport("acknex.dll", EntryPoint="error", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Error(string param0);

		[DllImport("acknex.dll", EntryPoint="timer", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Timer();

		[DllImport("acknex.dll", EntryPoint="dtimer", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern double Dtimer();

		[DllImport("acknex.dll", EntryPoint="breaks", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Breaks();

		[DllImport("acknex.dll", EntryPoint="port_in", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar PortIn(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="port_out", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar PortOut(ackvar param0, ackvar param1);

		[DllImport("acknex.dll", EntryPoint="wiimote_handle", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar WiimoteHandle(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="exec", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Exec(string param0, string param1);

		[DllImport("acknex.dll", EntryPoint="exec_wait", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar ExecWait(string param0, string param1);

		[DllImport("acknex.dll", EntryPoint="proc_kill", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar ProcKill(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="proc_kill2", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar ProcKill2(IntPtr param0, IntPtr param1);

		[DllImport("acknex.dll", EntryPoint="proc_status", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar ProcStatus(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="proc_status2", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar ProcStatus2(IntPtr param0, IntPtr param1);

		[DllImport("acknex.dll", EntryPoint="execute", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Execute(string param0);

		[DllImport("acknex.dll", EntryPoint="var_for_name", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr VarForName(string param0);

		[DllImport("acknex.dll", EntryPoint="ptr_first", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr PtrFirst(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="ptr_remove", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr PtrRemove(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="ptr_for_handle", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr PtrForHandle(ackvar param0);

		[DllImport("acknex.dll", EntryPoint="handle", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar Handle(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="sys_malloc", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr SysMalloc(long param0);

		[DllImport("acknex.dll", EntryPoint="sys_nxalloc", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr SysNxalloc(long param0);

		[DllImport("acknex.dll", EntryPoint="sys_free", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern void SysFree(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="sys_marker", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr SysMarker(string param0);

		[DllImport("acknex.dll", EntryPoint="_chr", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern string _chr(IntPtr param0);

		[DllImport("acknex.dll", EntryPoint="_str", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr _str(string param0);

		[DllImport("acknex.dll", EntryPoint="_vec", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		[return : MarshalAs(UnmanagedType.LPStruct)]
		public static extern Vector _vec(float param0, float param1, float param2);

		[DllImport("acknex.dll", EntryPoint="add_buffer", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar AddBuffer(string param0, IntPtr param1, long param2);

		[DllImport("acknex.dll", EntryPoint="add_folder", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar AddFolder(string param0);

		[DllImport("acknex.dll", EntryPoint="add_resource", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar AddResource(string param0);

		[DllImport("acknex.dll", EntryPoint="add_new", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar AddNew();

		[DllImport("acknex.dll", EntryPoint="add_struct", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar AddStruct(IntPtr param0, long param1);

		[DllImport("acknex.dll", EntryPoint="engine_getobj", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern long EngineGetobj(string param0);

		[DllImport("acknex.dll", EntryPoint="engine_getvar", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr EngineGetvar(string param0, ref int param1);

		[DllImport("acknex.dll", EntryPoint="engine_getvarinfo", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern long EngineGetvarinfo(IntPtr param0, string param1, string param2, ref int param3);

		[DllImport("acknex.dll", EntryPoint="engine_getfunc", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern long EngineGetfunc(string param0);

		[DllImport("acknex.dll", EntryPoint="engine_getscript", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern long EngineGetscript(string param0);

		[DllImport("acknex.dll", EntryPoint="engine_getscriptinfo", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern long EngineGetscriptinfo(IntPtr param0, IntPtr param1);

		[DllImport("acknex.dll", EntryPoint="engine_gettaskinfo", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern long EngineGettaskinfo(long param0, IntPtr param1, ref IntPtr param2);

		[DllImport("acknex.dll", EntryPoint="engine_callname4", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar EngineCallname4(string param0, long param1, long param2, long param3, long param4);

		[DllImport("acknex.dll", EntryPoint="engine_callscript4", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar EngineCallscript4(long param0, long param1, long param2, long param3, long param4);

		[DllImport("acknex.dll", EntryPoint="engine_debugposition", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar EngineDebugposition(IntPtr param0, ref int param1, ref int param2);

		[DllImport("acknex.dll", EntryPoint="engine_debugbreakpoint", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar EngineDebugbreakpoint(string param0, long param1, long param2);

		[DllImport("acknex.dll", EntryPoint="engine_debugstep", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern long EngineDebugstep(long param0);

		[DllImport("acknex.dll", EntryPoint="engine_status", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern long EngineStatus(long param0);

		[DllImport("acknex.dll", EntryPoint="engine_bind", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern long EngineBind();

		[DllImport("acknex.dll", EntryPoint="engine_callscript", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern ackvar EngineCallscript(long param0, long param1, long param2, long param3, long param4);

		[DllImport("acknex.dll", EntryPoint="engine_open", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern IntPtr EngineOpen(string param0, int param1);

		[DllImport("acknex.dll", EntryPoint="engine_frame", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern long EngineFrame();

		[DllImport("acknex.dll", EntryPoint="engine_close", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
		public static extern long EngineClose();

	}
}
