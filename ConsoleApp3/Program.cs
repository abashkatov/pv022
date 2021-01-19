using System;
using System.Text;
using static System.Console;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Принимать через аргументы командной строки два значения: высота матрицы, ширина матрицы.
            // Выводить матрицу на экран.
            /**
             * Принимать размер матрицы числами
             * 2 3
             *      0 1 2
             *      3 4 5
             * 
             * 3 4
             *      0  1  2  3
             *      4  5  6  7
             *      8  9 10 11
             * 
             * Принимать размер матрицы ключами со значениями
             * -h=2 -w=3
             * 
             * */

            WriteLine(args.Length);
            foreach (string arg in args) { 
                WriteLine(arg);
            }

            ReadKey();
        }
    }
}
