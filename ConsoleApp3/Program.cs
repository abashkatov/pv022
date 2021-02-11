using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using static System.Console;
using System.IO;
using System.Text;

namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            string source = "Hello World!";
            string dest;

            using (StreamWriter fs = new StreamWriter("example.txt", false))
            {
                fs.WriteLine(source);
            }

            using (StreamReader fs = new StreamReader("example.txt"))
            {
                dest = fs.ReadLine();
            }

            WriteLine(dest);

            ReadKey();
        }
    }
}
