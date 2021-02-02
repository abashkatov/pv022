using System;
using System.Collections;
using static System.Console;

namespace ConsoleApp3
{
    class A {
        // Исключения:
        //   T:System.ArgumentNullException:
        //     Свойство s имеет значение null.
        //
        //   T:System.FormatException:
        //     s имеет неправильный формат.
        //
        //   T:System.OverflowException:
        //     s представляет число, которое меньше значения System.Int32.MinValue или больше
        //     значения System.Int32.MaxValue.
        public int First(string s) {
            int age;
            try
            {
                age = Second(s);
            }
            catch (ArgumentException e)
            {
                throw new Exception("Our custom exception", e);
            }

            return age;
        }
        public int Second(string s) {
            int age = short.Parse(s);

            return age;
        }
        private int Parse(string s) {
            int age;
            if (int.TryParse(s, out age)) {
                return age;
            }

            throw new ArgumentException("Не удалось спарсить строку");
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

                try
                {
                    age = a.First(input);
                    WriteLine($"Ваш возраст {age}");
                }
                catch (Exception e)
                {
                    throw new Exception("Our custom exception", e);
                }


                WriteLine();
            }
            
            ReadKey();
        }
    }
}
