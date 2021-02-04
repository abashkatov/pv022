using System;
using System.Collections;
using System.Collections.Specialized;
using static System.Console;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new ArrayList(40);
            WriteLine("Count " + collection.Count);
            WriteLine("Capacity " + collection.Capacity);
            WriteLine();

            collection.Add("1");
            WriteLine("Count " + collection.Count);
            WriteLine("Capacity " + collection.Capacity);
            WriteLine();

            collection.Add("1");
            collection.Add("1");
            collection.Add("1");
            collection.Add("1");
            WriteLine("Count " + collection.Count);
            WriteLine("Capacity " + collection.Capacity);
            WriteLine();

            collection.Add("1");
            collection.Add("1");
            collection.Add("1");
            collection.Add("1");
            WriteLine("Count " + collection.Count);
            WriteLine("Capacity " + collection.Capacity);
            WriteLine();

            collection.Add("1");
            collection.Add("1");
            collection.Add("1");
            collection.Add("1");
            collection.Add("1");
            collection.Add("1");
            collection.Add("1");
            collection.Add("1");
            WriteLine("Count " + collection.Count);
            WriteLine("Capacity " + collection.Capacity);
            WriteLine();


            WriteLine(collection[0]);
            

            ReadKey();
        }
    }
}
