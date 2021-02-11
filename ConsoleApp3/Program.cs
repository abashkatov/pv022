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

            using (FileStream fs = new FileStream("example.txt", FileMode.OpenOrCreate))
            {
                byte[] buffer = Encoding.Default.GetBytes(source);
                fs.Write(buffer, 0, buffer.Length);
            }

            using (FileStream fs = new FileStream("example.txt", FileMode.Open))
            {
                byte[] buffer = new byte[fs.Length];
                int i = fs.Read(buffer, 0, (int)fs.Length);
                WriteLine("Прочитано " + i + " байт");
                dest = Encoding.Default.GetString(buffer);
            }
            WriteLine(dest);

            ReadKey();
        }
    }
}
