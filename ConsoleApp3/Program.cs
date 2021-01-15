using System;
using static System.Console;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string fio = "Ivanov Ivan Ivanovich";
            fio.Trim('h');

            string[] parts = fio.Split(' ');

            WriteLine("F: " + parts[0]);
            WriteLine("I: " + parts[1]);
            WriteLine("O: " + parts[2]);

            fio = parts[0] + ' ' + parts[1] + ' ' + parts[2];
            //fio = "{parts[0]} {parts[1]} {parts[2]}";
            WriteLine(fio);

            fio = string.Join(" ", parts[0], parts[1], parts[2]);
            WriteLine(fio);

            fio = string.Join(" ", parts);
            WriteLine(fio);

            ReadKey();
        }
    }
}
