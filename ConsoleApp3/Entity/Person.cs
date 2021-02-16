using System;

namespace ConsoleApp3.Entity
{
    [Serializable]
    public class Person
    {
        private static int count = 0;

        public readonly int ID;
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {
            ID = ++count;
        }
        public Person(string name, int age): this()
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
