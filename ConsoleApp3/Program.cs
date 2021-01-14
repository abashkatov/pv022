using System;
using static System.Console;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[3];

            names[0] = "Name1";
            names[1] = "Name2";
            names[2] = "Name3";
            
            foreach (string name in names)
            {
                WriteLine("Name: " + name);
            }

            int j = 0;
            int i;
            for (i = 0; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                if (i > 10)
                {
                    WriteLine(i);
                    break;
                }
                WriteLine(i);
            }
            WriteLine(i);


            i = 0;

            string ans;

            //Вариант 1
            WriteLine("Вам уже есть 18? (y/n)");
            ans = ReadLine();

            while (ans != "y" && ans != "n")
            {
                WriteLine("Ошибка ввода");
                WriteLine("Вам уже есть 18? (y/n)");
                ans = ReadLine();
            }

            // Вариант 2
            do
            {
                WriteLine("Вам уже есть 18? (y/n)");
                ans = ReadLine();
            } while (ans != "y" && ans != "n");

        Label2:
            WriteLine("Вам уже есть 18? (y/n)");
            ans = ReadLine();
            if (ans != "y" && ans != "n")
            {
                goto Label2;
            }


            ReadKey();
            return;
            // Консоль
            BackgroundColor = ConsoleColor.Gray;
            string hello = "Hello"; // 6
            /*
             *          3   5
             *      * * * * * * * * * *
             *      * * H e l l o   * *
             *      * * * * * * * * * *
             * 
             * */
            //int rows = LargestWindowHeight;
            //int cols = LargestWindowWidth;
            int rowMid = WindowHeight / 2;
            int colMid = WindowWidth / 2;
            int curColPos = colMid - 3;
            SetCursorPosition(curColPos, rowMid);
            WriteLine(hello);

            //Clear();

            ReadKey();
        }
    }
}
