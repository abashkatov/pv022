using System;
using System.Text;
using static System.Console;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание. Принимать через аргументы командной строки два значения: высота матрицы, ширина матрицы.
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
             * -h=2000 -w=3
             * 
             * */

            int h = 0, w = 0;
            foreach (string arg in args) 
            {
                // Вариант чтения 1
                //if (arg.StartsWith("-h=")) 
                //{
                //    h = int.Parse(arg.Substring(3));
                //} else if (arg.StartsWith("-w="))
                //{ 
                //    w = int.Parse(arg.Substring(3));
                //}

                // Вариант чтения 2
                string[] parts = arg.Split('=');
                switch (parts[0]) {
                    case "-h":
                        h = int.Parse(parts[1]);
                        break;
                    case "-w":
                        w = int.Parse(parts[1]);
                        break;
                    default:
                        WriteLine("Error");
                        return;
                }
            }
            if (h == 0 && w == 0) {
                WriteLine("Ошибка");
                return;
            }
            WriteLine($"H: {h}");
            WriteLine($"W: {w}");

            // Вариант вывода 1 - сделан самостоятельно

            // Вариант вывода 2
            int num = h * w;
            for (int i = 0; i < num; i++) {
                Write("{0, 5}", i);
                if ((i + 1) % w == 0)
                {
                    WriteLine();
                }
            }

            ReadKey();
        }
    }
}
