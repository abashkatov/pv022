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
            var collection = new HybridDictionary();
            collection.Add("Name0", "Ivan");
            collection.Add("Name1", "Ivan");
            collection.Add("Name2", "Ivan");
            collection.Add("Name3", "Ivan");
            collection.Add("Name4", "Ivan");
            collection.Add("Name5", "Ivan");
            collection.Add("Name6", "Ivan");
            collection.Add("Name7", "Ivan");
            ICollection keys = collection.Keys;
            WriteLine(keys.GetType().Name);

            collection.Add("Name9", "Ivan");
            keys = collection.Keys;
            WriteLine(keys.GetType().Name);

            ReadKey();
        }
    }
}
