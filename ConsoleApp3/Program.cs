using System;
using System.Collections;
using static System.Console;

namespace ConsoleApp3
{
    class Day: ICloneable
    {
        public Day(int number)
        {
            Number = number;
        }

        public int Number { get; set; }

        public object Clone()
        {
            return new Day(Number);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Day day = new Day(1),
                day2 = day.Clone() as Day;

            ReadKey();
        }
    }
}
