using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AckSharp
{
	public partial class Material : EngineObject
	{
		/// <summary>
		/// 
		/// </summary>
		/// <remarks>mtl_create</remarks>
		public Material()
			: base(ObjectType.Material, true, Native.NativeMethods.MtlCreate())
		{

		}

		internal Material(IntPtr reference)
			: base(ObjectType.Material, false, reference)
		{
		}

		public IntPtr Load(string source)
		{
			return Native.NativeMethods.EffectLoad(this, source);
		}
	}
}
