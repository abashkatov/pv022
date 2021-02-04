using System;
using System.Collections;
using static System.Console;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             *  Поколения
             * 0 - 256 Кб
             * 1 - 2 Мб
             * 2 - 10 Мб
             * */

            string s1 = new string('*', 100);
            WriteLine(GC.MaxGeneration);
            WriteLine("{0: ### ### ### ###}", GC.GetTotalMemory(false));
            WriteLine("Generation is " + GC.GetGeneration(s1));
            //ArrayList ar = new ArrayList();
            //for (int i = 0; i < 10; i++)
            //{
            //ar.Add(FillMemory(1024));
            //}
            //FillMemory2(64);
            //FillMemory2(64);
            GC.Collect();

            //WriteLine("{0: ### ### ### ###}", GC.GetTotalMemory(true));
            WriteLine("Generation is " + GC.GetGeneration(s1));
            GC.Collect();
            WriteLine("Generation is " + GC.GetGeneration(s1));

            //GC.Collect();
            //WriteLine(GC.GetTotalMemory(false));

            ReadKey();
        }

        static void FillMemory2(int size) {
            string s = new string('*', 342*size);
        }
        static string FillMemory(int size) {
            return new string('*', 342*size);
        }
    }
}
