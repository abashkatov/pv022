using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Person
    {
        public string Name;
        public int Age;
        public int Height;

        public Person()
        { }
        public Person(string name, int age, int height)
        {
            Name = name;
            Age = age;
            Height = height;
        }
    }
}
