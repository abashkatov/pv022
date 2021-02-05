using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using static System.Console;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            object o;
            int i = 5;

            o = i;
            i = (int)o;

            ReadKey();
        }
    }
}
