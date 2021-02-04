using System;
using System.Collections;
using static System.Console;

namespace ConsoleApp3
{
    class Resource
    {
        string Name;
        string s = "1";

        public Resource(string name)
        {
            Name = name;
        }

        ~Resource()
        {
            WriteLine(Name + " has been finalized");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Start");
            /*
            1. Выделение памяти
            2. Задание состояния объекта
            3. Использование объекта
            ---- Сборщик мусора ----
            4. Уничтожение состояния
            5. Освобождение памяти
            */

            Resource r = new Resource("O1");
            CreateResource();

            GC.Collect();

            ReadKey();
        }
        public static void CreateResource()
        {
            Resource r = new Resource("O2");
        }
    }
}
