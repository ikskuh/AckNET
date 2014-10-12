using System;

namespace AckSharp
{
	public class EngineEventArgs : EventArgs
	{
		public EngineEventArgs(ackvar param)
		{
			this.Param = param;
		}

		public ackvar Param { get; private set; }

		public ackvar ReturnValue { get; set; }
}
}