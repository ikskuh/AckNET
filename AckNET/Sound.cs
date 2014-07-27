using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AckNET
{
	public sealed partial class Sound : EngineObject
	{
		public Sound(string fileName)
			: base(true)
		{
			this.InternalPointer = Native.NativeMethods.SndCreate(fileName);
		}

		public Sound(IntPtr handle)
			: base(false)
			{
			this.InternalPointer = handle;
		}

		public SoundHandle Play(ackvar volume, ackvar balance)
		{
			return new SoundHandle(Native.NativeMethods.SndPlay(this.InternalPointer, volume, balance));
		}

		public SoundHandle Loop(ackvar volume, ackvar balance)
		{
			return new SoundHandle(Native.NativeMethods.SndLoop(this.InternalPointer, volume, balance));
		}
	}

	public sealed class SoundHandle
	{
		private readonly ackvar handle;

		public SoundHandle(ackvar handle)
		{
			this.handle = handle;
		}

		public void Start()
		{
			Native.NativeMethods.SndStart(this.handle);
		}

		public void Stop()
		{
			Native.NativeMethods.SndStop(this.handle);
		}

		public void Pause()
		{
			Native.NativeMethods.SndPause(this.handle);
		}

		public void Tune(ackvar volume, ackvar frequency, ackvar balance)
		{
			Native.NativeMethods.SndTune(this.handle, volume, frequency, balance);
		}

		public ackvar Position { get { return Native.NativeMethods.SndPlaying(this.handle); } }

		public bool IsPlaying { get { return (bool)this.Position; } }
	}
}
