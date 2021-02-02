using System;
using System.Collections;
using static System.Console;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.MaxValue - 1;
            WriteLine(n); // 1  0 0 0 0  0 0 0 0
            n++;
            WriteLine(n);
            unchecked
            {
                n++;
                n--;
            }
            WriteLine(n);
            byte r = unchecked(++n);

            WriteLine(r);

            ReadKey();
        }
    }
}
