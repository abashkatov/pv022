using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Model
{
    public class Person
    {
        public static string Name1;

        private string Name;
        public uint Age;

        public Person(string Name) {
            System.Console.WriteLine("Конструктор private Person(string Name)");
            this.Name = Name;
        }
        public Person(string Name, uint age): this(Name)
        {
            System.Console.WriteLine("Конструктор public Person(string Name, uint age): this(Name)");
            this.Name = Name;

            Age = age;
        }

        public string GetName()
        {
            return Name;
        }
        public void SetName(string Name)
        {
            this.Name = Name;
        }

        public void SetName(char[] chars)
        {
            Name = new string(chars);
        }
        public void SetAge(uint Age)
        {
            this.Age = Age;
        }
    }
}
