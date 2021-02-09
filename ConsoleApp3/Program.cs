using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using static System.Console;

namespace ConsoleApp3
{
    public class Program
    {
        static void WriteName(Pet obj) {
            WriteLine(obj.Name);
        }
        static void Main(string[] args)
        {
            List<Pet> pets = new List<Pet>();
            pets.Add(new Pet("First"));
            pets.Add(new Pet("Second"));

            pets.ForEach(WriteName);

            ReadKey();
        }
    }
    class Pet {
        public Pet(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}
