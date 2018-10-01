using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Program1
{
	public class TimerEventArgs : EventArgs
	{
		public Time EventTime { set; get; }
	}

	public delegate void Delegator(Alarm sender, TimerEventArgs e);

	public class Alarm
	{
		public event Delegator Delegator;

		public uint BeepingInterval { set; get; } = 60;
		public Time Time { set; get; } = new Time();
		private readonly SortedSet<Schedule> _upcoming = new SortedSet<Schedule>();
		private readonly SortedSet<Schedule> _running = new SortedSet<Schedule>();

		public void AddSchedule(Time time)
		{
			if (Time > time) return;
			_upcoming.Add(Schedule.GetSchedule(time));
		}

		private void DisplayTime(Alarm sender, TimerEventArgs e)
		{
			Console.WriteLine($"{e.EventTime}");
		}

		public void Update()
		{
			var timeEventArgs = new TimerEventArgs ();
			while (true)
			{
				timeEventArgs.EventTime = Time;
				
				while (_upcoming.Count != 0 && Time == _upcoming.Min.Time)
				{
					Delegator += Beep;
					_running.Add(_upcoming.Min);
					_upcoming.Remove(_upcoming.Min);
				}
				
				Delegator?.Invoke(this, timeEventArgs);
				Thread.Sleep(1000);
				Time = Time.AddSeconds();

				while (_running.Count != 0 && Time - BeepingInterval > _running.Min.Time)
				{
					Delegator -= Beep;
					_running.Remove(_running.Min);
				}

				if (_upcoming.Count + _running.Count == 0) break;
			}
		}

		public static void Beep(Alarm sender, TimerEventArgs e)
		{
			Console.WriteLine($"Beeping {e.EventTime}");
			Console.Write('\a');
		}
	}
}