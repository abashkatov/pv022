using System;
using static System.Console;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Создание текстовых строк
            string[] str1 = new string[3];
            str1[0] = new string(new char[] { 'c', 'z', '1' });
            str1[1] = new string(new char[] { 'c', '1', '2', '3', '4', '5' }, 2, 3);
            str1[2] = new string('c', 4);

            foreach (string str in str1)
            {
                WriteLine(str);
            }

            // Конкатенация, интерполяция и форматирование строк
            string
                path = @"C:\WINDOWS\Microsoft.Net\assembly\",
                fileName = "file",
                fullPath = path + fileName + ".txt"
            ;
            WriteLine(fullPath);
            
            fullPath = $"C:\\WINDOWS\\Microsoft.Net\\assembly\\{fileName}.txt";
            WriteLine(fullPath);

            WriteLine("{0, 10:p}, {1, 10}, {2, 10}", 10, 10000, 20);
            WriteLine("{0, 10:p}, {1, 10}, {2, 10}", 100000, 10, 20);
            WriteLine("{0, 10:p}, {1, 10}, {2, 10:### ### ###}", 100000, 10, 2000000);

            ReadKey();
        }
    }
}
