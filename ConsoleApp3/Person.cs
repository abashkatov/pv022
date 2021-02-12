using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    [Serializable]
    public class Person
    {
        private static int count = 0;

        public readonly int ID;
        public string Name { get; set; }
        [JsonPropertyName("AgeAge")]
        public int Age { get; set; }
        [JsonIgnore]
        public int Height { get; set; }

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
