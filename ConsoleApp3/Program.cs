using System;
using System.Collections;
using static System.Console;

namespace ConsoleApp3
{
    class Resource: IDisposable
    {
        string Name;
        string s = "1";

        public Resource(string name)
        {
            Name = name;
        }

        public void Dispose()
        {
            WriteLine("Dispose " + Name);
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

            using (Resource r = new Resource("O1")) 
            {

                r.ToString();
                CreateResource();
                throw new Exception();
                WriteLine("LastLine");
            }
            
            
            //GC.Collect();

            ReadKey();
        }
        public static void CreateResource()
        {
            Resource r = new Resource("O2");
            //r.Dispose();
        }
    }
}
