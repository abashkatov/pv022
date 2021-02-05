using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using static System.Console;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new List<string>();
            collection.Add("sdfgdg");
            WriteLine(collection[0]);

            List<string> rC;
            var registredCollection = Register<List<string>, int, int, int, int>(collection);
            registredCollection = Register<List<string>, string, int, int, int>(collection);
            if (registredCollection is List<string>) {
                rC = registredCollection as List<string>;
            }

            ReadKey();
        }

        static T Register<T, R, S, A, Vbf>(T item) {
            R t;
            return item;
        }
    }
}
