using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AckNET
{
	public sealed class Scheduler
	{
		private List<ScheduleItem> items = new List<ScheduleItem>();

		public void Start(SchedulableMethod method)
		{
			this.items.Add(new ScheduleItem(method().GetEnumerator()));
		}

		public bool Update()
		{
			// Clone items here to be able to remove them
			foreach (var item in items.ToArray())
			{
				if (item.Schedule())
					items.Remove(item);
			}
			return items.Count > 0;
		}

		private class ScheduleItem
		{
			private IEnumerator<Wait> enumerator;

			public ScheduleItem(IEnumerator<Wait> enumerator)
			{
				this.enumerator = enumerator;
			}

			public bool Schedule()
			{
				if (enumerator.Current == null || enumerator.Current.IsFinished)
				{
					if (enumerator.MoveNext() == false)
						return true; // Kill if we finished the enumator.
				}
				if (enumerator.Current == null)
				{
					throw new InvalidOperationException("Cannot schedule null.");
				}
				enumerator.Current.Tick();

				return false;
			}
		}
	}

	public delegate IEnumerable<Wait> SchedulableMethod();
}