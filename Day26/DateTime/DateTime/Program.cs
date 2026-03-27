using System;

namespace DateTimeDay26
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DateTime today = DateTime.Now;

            Console.WriteLine($"Today's date: {today.ToShortDateString()}");
            Console.WriteLine($"Day of the week: {today.DayOfWeek}");
        }
    }
}