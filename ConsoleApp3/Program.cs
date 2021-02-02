using System;
using System.Collections;
using static System.Console;

namespace ConsoleApp3
{
    class A
    {
        public int First(string s)
        {
            int age;
            try
            {
                age = short.Parse(s);
                WriteLine("End of try");
                return age;
            }
            catch (Exception e) {

                throw;
            }
            finally {
                WriteLine("finally");
                age = 15;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            string input;
            int age;
            while (true)
            {
                Write("Введите ваш возраст: ");
                input = ReadLine();
                if (input == "") {
                    input = null;
                }

                age = a.First(input);
                WriteLine($"Ваш возраст {age}");

                WriteLine();
            }
            
            ReadKey();
        }
    }
}
