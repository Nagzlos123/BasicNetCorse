using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FistBasicNetCorse
{
    internal static class DateTimeFunctions
    {
        public static bool IsDateBetween(DateTime date, DateTime from, DateTime to)
        {
            return date > from && date < to;
        }

        // DateTime extension metod 
        public static bool IsBetween(this DateTime date, DateTime from, DateTime to)
        {
            return date > from && date < to;
        }
        public static void DateTimeModifications()
        { 
            DateTime now = DateTime.Now;
            DateTime openDate = new DateTime(1992, 11, 15);

            TimeSpan result = now - openDate;
            Console.WriteLine(result.Days);
            Console.WriteLine(result.TotalDays);

            DateTime expiresAt = now.AddDays(7);
            DateTime expiresAt2 = now.Add(new TimeSpan(7, 5, 0));

            bool expiresAtTheSameDay = expiresAt == expiresAt2;
            Console.WriteLine($"expiresAtTheSameDay: {expiresAtTheSameDay}");
        }

        public static void DateTimeFormating()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToString("g"));
            Console.WriteLine(now.ToString("G"));
            Console.WriteLine(now.ToString("yyyy : MM : dd | hh : mm : ss")); // castom formating
        }

        public static void TimeMeasurement()
        {
            Console.WriteLine("What is 2 + 2?");
            Console.WriteLine("A) 8");
            Console.WriteLine("B) 1");
            Console.WriteLine("C) 4");
            Console.WriteLine("D) 5");

            DateTime start = DateTime.Now;
            Stopwatch stopwatch = Stopwatch.StartNew();

            string userAnswer = Console.ReadLine();

            stopwatch.Stop();
            DateTime end = DateTime.Now;

            TimeSpan resonceTime = end - start;
            Console.WriteLine($"Respons took you: {resonceTime.TotalSeconds} Seconds");
            Console.WriteLine($"Respons took you: {stopwatch.Elapsed.TotalSeconds} Seconds");
        }

        public static void Helpers()
        {
            int daysInFeb = DateTime.DaysInMonth( 2024, 2 );
            bool is2024LeapYear = DateTime.IsLeapYear( 2024 );

            Console.WriteLine($"daysInFeb: {daysInFeb}");
            Console.WriteLine($"is2024LeapYear: {is2024LeapYear}");
        }
    }
}
