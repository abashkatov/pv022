using System;
using System.Collections;
using static System.Console;

namespace ConsoleApp3
{
    class DayComparator : IComparer
    {
        public int Compare(object x, object y)
        {
            int a = (x as Day).Number;
            int b = (y as Day).Number;

            return a == b ? 0 : (a > b ? 1 : -1);
        }
    }
    class Day
    {
        public Day(int number)
        {
            Number = number;
        }

        public int Number { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Day[] days = { 
                new Day(2000000000),
                new Day(2),
                new Day(5),
                new Day(-2000000000),
            };
            Array.Sort(days, new DayComparator());
            foreach (Day day in days) {
                WriteLine(day.Number);
            }
            ReadKey();
        }
    }
}
