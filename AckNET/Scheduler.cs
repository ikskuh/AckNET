using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AckNET
{
	public sealed class Scheduler
	{
		private static ThreadLocal<Scheduler> current = new ThreadLocal<Scheduler>(() => null);
		private List<Job> items = new List<Job>();

		/// <summary>
		/// Starts a scheduleable method.
		/// </summary>
		/// <param name="method"></param>
		public Job Start(SchedulableMethod method)
		{
			return this.Start(method());
		}

		/// <summary>
		/// Starts a scheduleable enumerable.
		/// </summary>
		/// <param name="method"></param>
		public Job Start(IEnumerable<Wait> method)
		{
			var item = new Job(method.GetEnumerator());
			this.items.Add(item);
			return item;
		}

		public bool Update()
		{
			current.Value = this;

			// Sort jobs
			items.Sort((a, b) => Math.Sign(a.ExecutionTime - b.ExecutionTime));

			// Clone items here to be able to remove them
			foreach (var item in items.ToArray())
			{
				if (item.Schedule())
					items.Remove(item);
			}
			current.Value = null;
			return items.Count > 0;
		}

		public static Scheduler Current { get { return current.Value; } }
	}

	public class Job
	{
		private static ThreadLocal<Job> current = new ThreadLocal<Job>(() => null);
		private IEnumerator<Wait> enumerator;
		private bool isFinished = false;

		internal Job(IEnumerator<Wait> enumerator)
		{
			this.enumerator = enumerator;
		}

		internal bool Schedule()
		{
			current.Value = this;
			if (enumerator.Current == null || enumerator.Current.IsFinished)
			{
				if (enumerator.MoveNext() == false)
				{
					current.Value = null;
					this.isFinished = true;
					return true; // Kill if we finished the enumator.
				}
			}
			if (enumerator.Current == null)
			{
				current.Value = null;
				throw new InvalidOperationException("Cannot schedule null.");
			}
			enumerator.Current.Tick();
			current.Value = null;
			return false;
		}

		/// <summary>
		/// Gets a value that indicates wheather the job is still active or not.
		/// </summary>
		/// <returns></returns>
		public bool IsFinished { get { return this.isFinished; } }

		/// <summary>
		/// Gets or sets the execution time of the job.
		/// The higher time the later execution will happen.
		/// </summary>
		/// <returns></returns>
		public double ExecutionTime { get; set; } = 1.0;

		/// <summary>
		/// Gets the currently executed job.
		/// Can be used to change priority.
		/// </summary>
		/// <returns></returns>
		public static Job Current { get { return current.Value; } }
	}

	public delegate IEnumerable<Wait> SchedulableMethod();

	public delegate IEnumerable<Wait> EntityAction(Entity me);
}