using System;

namespace AckNET
{
	/// <summary>
	/// Item returned by a scheduler method
	/// </summary>
	public abstract class Wait
	{
		/// <summary>
		/// Gets called when wait gets scheduled.
		/// </summary>
		protected internal virtual void Tick()
		{
		}

		public abstract bool IsFinished { get; }

		/// <summary>
		/// Waits for the given amount of frames.
		/// </summary>
		/// <param name="frameCount"></param>
		/// <returns></returns>
		public static Wait ForFrames(int frameCount)
		{
			return new WaitForFrames(frameCount);
		}

		/// <summary>
		/// Waits for a given amount of seconds.
		/// </summary>
		/// <param name="seconds"></param>
		/// <returns></returns>
		public static Wait ForSeconds(double seconds)
		{
			return new WaitForSeconds(seconds);
		}

		/// <summary>
		/// Waits for an IAsyncResult.
		/// </summary>
		/// <param name="asyncResult"></param>
		/// <returns></returns>
		public static Wait ForAsync(IAsyncResult asyncResult)
		{
			return new WaitForAsync(asyncResult);
		}

		/// <summary>
		/// Waits for a predicate to become true.
		/// </summary>
		/// <param name="asyncResult"></param>
		/// <returns></returns>
		public static Wait ForPredicate(Func<bool> predicate)
		{
			return new WaitForPredicate(predicate);
		}
	}

	/// <summary>
	/// Waits for an IAsyncResult
	/// </summary>
	public sealed class WaitForAsync : Wait
	{
		private IAsyncResult asyncResult;

		public WaitForAsync(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
				throw new ArgumentNullException("asyncResult");
			this.asyncResult = asyncResult;
		}

		public override bool IsFinished
		{
			get { return this.asyncResult.IsCompleted; }
		}
	}

	/// <summary>
	/// Waits for a given amount of frames.
	/// </summary>
	public sealed class WaitForFrames : Wait
	{
		private int frameCount;

		public WaitForFrames(int frameCount)
		{
			this.frameCount = frameCount;
		}

		protected internal override void Tick()
		{
			this.frameCount -= 1;
		}

		public override bool IsFinished
		{
			get { return this.frameCount <= 0; }
		}
	}

	/// <summary>
	/// Waits for a given amount of seconds.
	/// </summary>
	public sealed class WaitForSeconds : Wait
	{
		private DateTime end;

		public WaitForSeconds(double seconds)
		{
			this.end = DateTime.Now + TimeSpan.FromSeconds(seconds);
		}

		public override bool IsFinished
		{
			get { return DateTime.Now >= this.end; }
		}
	}

	/// <summary>
	/// Waits for a predicate to become true.
	/// </summary>
	public sealed class WaitForPredicate : Wait
	{
		private Func<bool> end;
		bool finished = false;

		public WaitForPredicate(Func<bool> predicate)
		{
			this.end = predicate;
        }

		protected internal override void Tick()
		{
			if (this.finished)
				return;

			finished = this.end();
        }

		public override bool IsFinished
		{
			get { return finished; }
		}
	}
}