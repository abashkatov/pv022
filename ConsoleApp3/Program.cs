using System;
using System.Collections;
using System.Collections.Specialized;
using static System.Console;

namespace ConsoleApp3
{
    class Comparator : IComparer
    {
        public int Compare(object x, object y)
        {
            if ((int)y == (int)x)
            {
                return 0;
            }

            return (int)y > (int)x ? 1 : -1;
        }
            // 2000_000_000 + 2000_000_000
    }
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new SortedList(new Comparator());
            collection.Add(-2_000_000_015, 5);
            collection.Add("dfg", "sdgdfg");
            collection.Add(new Comparator(), new Comparator());
            collection.Add(2000_000_001, 5);
            foreach (DictionaryEntry pair in collection) {
                WriteLine(pair.Key);
            }
            //var stack = new Stack(); // LIFO = Last In First Out
            //var queue = new Queue(); // FIFO = First In First Out


            ReadKey();
        }
    }
}
