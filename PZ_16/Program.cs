using System;

namespace PZ_16
{
    public class CustomDate : ICloneable
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public CustomDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        // Overload "-" operator to calculate the difference in days between two dates
        public static int operator -(CustomDate d1, CustomDate d2)
        {
            DateTime date1 = new DateTime(d1.Year, d1.Month, d1.Day);
            DateTime date2 = new DateTime(d2.Year, d2.Month, d2.Day);
            return Math.Abs((date1 - date2).Days);
        }

        // Overload "+" operator to add days to a date
        public static CustomDate operator +(CustomDate d, int days)
        {
            DateTime date = new DateTime(d.Year, d.Month, d.Day);
            date = date.AddDays(days);
            return new CustomDate(date.Day, date.Month, date.Year);
        }

        // Implementing the ICloneable interface (shallow clone)
        public object Clone()
        {
            return new CustomDate(this.Day, this.Month, this.Year);
        }

        public override string ToString()
        {
            return $"{Day:D2}.{Month:D2}.{Year}";
        }
    }

    class Program
    {
        static void Main()
        {
            CustomDate date1 = new CustomDate(10, 4, 2025);
            CustomDate date2 = new CustomDate(1, 1, 2025);

            int daysBetween = date1 - date2;
            Console.WriteLine($"Difference between dates: {daysBetween} days");

            CustomDate newDate = date2 + 40;
            Console.WriteLine($"New date after adding 40 days: {newDate}");

            CustomDate clonedDate = (CustomDate)date2.Clone();
            Console.WriteLine($"Cloned date: {clonedDate}");
        }
    }
}
