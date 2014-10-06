using System;

namespace AckNET
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