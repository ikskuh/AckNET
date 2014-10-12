using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AckSharp
{
	public sealed partial class Sound : EngineObject
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="fileName"></param>
		/// <remarks>snd_create</remarks>
		public Sound(string fileName)
			: base(ObjectType.Sound, true, Native.NativeMethods.SndCreate(fileName))
		{

		}

		internal Sound(IntPtr handle)
			: base(ObjectType.Sound, false, handle)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="volume"></param>
		/// <param name="balance"></param>
		/// <returns></returns>
		/// <remarks>snd_play</remarks>
		public SoundHandle Play(ackvar volume, ackvar balance)
		{
			CheckValid();
			return new SoundHandle(Native.NativeMethods.SndPlay(this.InternalPointer, volume, balance));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="volume"></param>
		/// <param name="balance"></param>
		/// <returns></returns>
		/// 
		/// <remarks>snd_loop</remarks>
		public SoundHandle Loop(ackvar volume, ackvar balance)
		{
			CheckValid();
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

		/// <summary>
		/// 
		/// </summary>
		/// <remarks>snd_start</remarks>
		public void Start()
		{
			Native.NativeMethods.SndStart(this.handle);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <remarks>snd_stop</remarks>
		public void Stop()
		{
			Native.NativeMethods.SndStop(this.handle);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <remarks>snd_pause</remarks>
		public void Pause()
		{
			Native.NativeMethods.SndPause(this.handle);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="volume"></param>
		/// <param name="frequency"></param>
		/// <param name="balance"></param>
		/// <remarks>snd_tune</remarks>
		public void Tune(ackvar volume, ackvar frequency, ackvar balance)
		{
			Native.NativeMethods.SndTune(this.handle, volume, frequency, balance);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		/// <remarks>snd_playing</remarks>
		public ackvar Position { get { return Native.NativeMethods.SndPlaying(this.handle); } }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		/// <remarks>snd_playing</remarks>
		public bool IsPlaying { get { return (bool)this.Position; } }
	}
}
