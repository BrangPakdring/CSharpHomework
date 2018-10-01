using System;

namespace Program1
{
	public class Time : IComparable
	{
		private int Hour { get; }
		private int Minute { get; }
		private int Second { get; }
		
		protected bool Equals(Time other)
		{
			return Hour == other.Hour && Minute == other.Minute && Second == other.Second;
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != this.GetType()) return false;
			return Equals((Time) obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = Hour;
				hashCode = (hashCode * 397) ^ Minute;
				hashCode = (hashCode * 397) ^ Second;
				return hashCode;
			}
		}

		public Time()
		{
			var currentTime = DateTime.Now;
			Hour = currentTime.Hour;
			Minute = currentTime.Minute;
			Second = currentTime.Second;
		}

		public Time(Time time)
		{
			Hour = time.Hour;
			Minute = time.Minute;
			Second = time.Second;
		}

		public Time(int hour, int minute, int second)
		{
			Hour = hour;
			Minute = minute;
			Second = second;
		}

		public int CompareTo(object obj)
		{
			if (!(obj is Time))
				throw new Exception("invalid comparision");
			return this - (Time) obj;
		}

		public static implicit operator int(Time time)
		{
			return time.Hour * 10000 + time.Minute * 100 + time.Second;
		}

		public Time AddSeconds(long span = 1)
		{
			if (span < 0 || span > 1919810114514L) throw new Exception($"add {span} seconds failed");
			var newSecond = Second + (int) (span % 86400);
			var newMinute = Minute;
			var newHour = Hour;

			if (newSecond >= 60)
			{
				newMinute += newSecond / 60;
				newSecond %= 60;
			}

			if (newMinute >= 60)
			{
				newHour += newMinute / 60;
				newMinute %= 60;
			}

			if (newHour >= 24) newHour %= 24;

			return new Time(newHour, newMinute, newSecond);
		}

		public static bool operator ==(Time lhs, Time rhs)
		{
			if (lhs is null && rhs is null) return true;
			if (lhs is null || rhs is null) return false;
			return lhs.Hour == rhs.Hour && lhs.Minute == rhs.Minute && lhs.Second == rhs.Second;
		}

		public static bool operator !=(Time lhs, Time rhs)
		{
			return !(lhs == rhs);
		}

		public override string ToString()
		{
			return $"{Hour:00}:{Minute:00}:{Second:00}";
		}
	}
}