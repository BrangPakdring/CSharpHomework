using System;
using System.Collections.Generic;

namespace Program1
{
	class Program
	{
		static void Main(string[] args)
		{
			var alarm = new Alarm();
			var dateTime = DateTime.Now;
			var dateTime1 = dateTime.AddSeconds(10);
			var time = new Time();
			
			var alarmTime1 = time.AddSeconds(5);
			var alarmTime2 = time.AddSeconds(10);
			
			alarm.AddSchedule(alarmTime1);
			alarm.AddSchedule(alarmTime2);
			alarm.AddSchedule(alarmTime1);
			
			alarm.Update();
		}
	}
}