using System;

namespace AckSharp
{
	public sealed class EntityEventArgs : EventArgs
	{
		internal EntityEventArgs(Entity ent)
		{
			this.Entity = ent;
		}

		public Entity Entity { get; private set; }
	}
}