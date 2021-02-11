using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Person
    {
        private static int count = 0;

        public readonly int ID;
        public string Name;
        public int Age;
        public int Height;

        public Person()
        {
            ID = ++count;
        }
        public Person(string name, int age, int height): this()
        {
            Name = name;
            Age = age;
            Height = height;
        }
    }
}
