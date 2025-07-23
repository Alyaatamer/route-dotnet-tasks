namespace Task3.Third_Project
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
            Calculate();
        }

       
        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            totalSeconds %= 3600;
            Minutes = totalSeconds / 60;
            Seconds = totalSeconds % 60;
            Calculate();
        }

        public Duration()
        {
        }

        private void Calculate()
        {
            if (Minutes >= 60)
            {
                Hours += Minutes / 60;
                Minutes %= 60;
            }
            if (Seconds >= 60)
            {
                Minutes += Seconds / 60;
                Seconds %= 60;
            }           
        }

        public static Duration operator +(Duration d1, Duration d2)
        {
            int total1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int total2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
            return new Duration(total1 + total2);
        }


        public static Duration operator +(Duration d, int seconds)
        {
            int total = d.Hours * 3600 + d.Minutes * 60 + d.Seconds + seconds;
            return new Duration(total);
        }


        public static Duration operator +(int seconds, Duration d)
        {
            return d + seconds;
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            int total1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int total2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
            return new Duration(total1 - total2);
        }

        public static Duration operator ++(Duration d)
        {
            return d + 60;
        }

        public static Duration operator --(Duration d)
        {
            return d + (-60);
        }

        public static bool operator >(Duration d1, Duration d2)
        {
            int total1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int total2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
            return total1 > total2;
        }
        public static bool operator <(Duration d1, Duration d2)
        {
            int total1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int total2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
            return total1 < total2;
        }

        public static bool operator ==(Duration d1, Duration d2)
        {
            if (ReferenceEquals(d1, d2)) return true;
            if (ReferenceEquals(d1, null) || ReferenceEquals(d2, null)) return false;

            return d1.Hours == d2.Hours &&
                   d1.Minutes == d2.Minutes &&
                   d1.Seconds == d2.Seconds;
        }

        public static bool operator !=(Duration d1, Duration d2)
        {
            return !(d1 == d2);
        }
        public static bool operator true(Duration d)
        {
            return d.Hours != 0 || d.Minutes != 0 || d.Seconds != 0;
        }

        public static bool operator false(Duration d)
        {
            return d.Hours == 0 && d.Minutes == 0 && d.Seconds == 0;
        }

        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(1, 1, 1, d.Hours, d.Minutes, d.Seconds);
        }

        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1 > d2 || d1 == d2;
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1 < d2 || d1 == d2;
        }
        public override string ToString()
        {
            string result = "";
            if (Hours > 0) result += $"Hours: {Hours}, ";
            if (Hours > 0 || Minutes > 0) result += $"Minutes :{Minutes}, ";
            result += $"Seconds :{Seconds}";
            return result;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Duration other)
                return Hours == other.Hours && Minutes == other.Minutes && Seconds == other.Seconds;
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }
    }
}
