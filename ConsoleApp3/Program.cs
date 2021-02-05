using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using static System.Console;

namespace ConsoleApp3
{
    class Person { }
    class Client: Person { }
    class Custom<T> where T : IList
    { 

    }
    class Program
    {
        // Перерыв до 20-20
        static void Main(string[] args)
        {
            var cString = new Custom<ArrayList>();
            var cPerson = new Custom<Person>();

            ReadKey();
        }
    }
}
