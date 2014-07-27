namespace AckNET.Test
{
	public static class Level
	{
		public static void Load(string fileName)
		{
			Native.NativeMethods.LevelLoad(fileName);
		}
		public static void Free()
		{
			Native.NativeMethods.LevelFree();
		}
		public static void Mark()
		{
			Native.NativeMethods.LevelMark();
		}
	}
}