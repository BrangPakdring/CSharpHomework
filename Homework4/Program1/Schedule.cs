using System;

namespace Program1
{
	public class Schedule : IComparable
	{
		public Time Time { set; get; }
		private int Id { set; get; }
		private static int Count { set; get; } = 0;

		public static Schedule GetSchedule(Time time)
		{
			return new Schedule {Time = time, Id = Count++};
		}

		public int CompareTo(object obj)
		{
			if (!(obj is Schedule))throw new InvalidOperationException();
			var rhs = (Schedule) obj;
			if (this.Time != rhs.Time) return this.Time - rhs.Time;
			return this.Id - rhs.Id;
		}
	}
}