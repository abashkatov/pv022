using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using static System.Console;

namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> query;
            int[] intRange = { 11, 23, 1, 2};

            query = from i in intRange
                    where i % 2 == 1
                    orderby i
                    select i;

            foreach (int i in query) {
                WriteLine(i);
            }

            ReadKey();
        }
    }
}
