using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using static System.Console;

namespace ConsoleApp3
{
    class Days
    {
        public IEnumerator<string> GetEnumerator()
        {
            string[] days = {"Понедельник",
            "Вторник",
            "Среда",
            "Четверг" };
            foreach (string day in days)
            {
                yield return day;
            }
            string[] days2 = {
                "Пятница",
            "Суббота" };
            foreach (string day in days2)
            {
                yield return day;
            }
            yield return "Воскресенье";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var days = new Days();
            foreach (var day in days) {
                WriteLine(day);
            }
            //foreach (var day in days) {
            //    WriteLine(day);
            //}
            ReadKey();
        }
    }
}
