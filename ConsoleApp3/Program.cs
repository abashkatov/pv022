using System;
using System.Collections;
using static System.Console;

namespace ConsoleApp3
{

    class A
    {
        public bool isAllow(string currentAge, string allowAge)
        {
            int nCurrentAge, nAllowAge;

            try
            {
                nCurrentAge = int.Parse(currentAge);
            }
            catch (Exception e) {
                ArgumentException exception = new ArgumentException(e.Message, nameof(currentAge), e);
                throw exception;
            }

            nAllowAge = int.Parse(allowAge);

            //try { } catch (Exception e) { }
            //ArgumentException exception = new ArgumentException(e.Message, "", e);
            //throw exception;
            // "currentAge"
            // nameof(currentAge)

            return nCurrentAge >= nAllowAge;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            string currentAge, allowAge;
            bool result = false;
            do
            {
                Write("Введите ваш возраст: ");
                currentAge = ReadLine();
                Write("Введите возраст, с которого разрешены операции: ");
                allowAge = ReadLine();
                try
                {
                    result = a.isAllow(currentAge, allowAge);
                    if (!result)
                    {
                        WriteLine("Операция запрещена");
                    }
                }
                catch (ArgumentException e) {
                    WriteLine($"Error input argument {e.ParamName} is missing:" + e.Message);
                }


                WriteLine();
            } while (!result);
            WriteLine("Операция РАЗРЕШЕНА");

            ReadKey();
        }
    }
}
