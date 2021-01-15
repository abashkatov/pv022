using System;
using static System.Console;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][];

            arr[0] = new int[3];
            arr[0][0] = 1;
            arr[0][1] = 2;
            arr[0][2] = 3;

            arr[1] = new int[5] { 4, 5, 6, 7, 8 };

            arr[2] = new int[] { 4, 5, 6, 9 };


            for (int i = 0; i < arr.Length; i++) {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Write(arr[i][j] + "   ");
                }
                WriteLine();
            }
            ReadKey();
        }
    }
}
