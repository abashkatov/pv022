using System;
using static System.Console;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] 
                names1 = { "Name1" , "Name2", "Name3", "NameN" },
                names2 = { "Name4" , "Name5", "Name6" },
                namesTotal = new string[2]
            ;

            namesTotal = new string[names1.Length + names2.Length];
            int currentPosition = 0;
            foreach (string name in names1)
            {
                namesTotal[currentPosition] = names1[currentPosition];
                currentPosition++;
            }
            foreach (string name in names2)
            {
                namesTotal[currentPosition] = names2[currentPosition - names1.Length];
                currentPosition++;
            }
            foreach (string name in namesTotal)
            {
                WriteLine(name);
            }


            ReadKey();
        }
    }
}
