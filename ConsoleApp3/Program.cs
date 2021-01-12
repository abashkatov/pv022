using System;
using static System.Console;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
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
