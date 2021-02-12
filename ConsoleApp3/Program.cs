using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using static System.Console;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using System.Text.Json;

namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Перерыв до 20-10
            List<Person> personsBefore = new List<Person>();
            personsBefore.Add(new Person("Name 1", 20, 180));
            personsBefore.Add(new Person("Name 2", 25, 180));

            List<Person> personsAfter = new List<Person>();

            foreach (Person person in personsBefore)
            {
                WriteLine(person.Name);
            }
            
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Person>));
            using (FileStream fs = new FileStream("data.xml", FileMode.Truncate))
            {
                xmlSerializer.Serialize(fs, personsBefore);
            }

            {
                JsonSerializerOptions options = new JsonSerializerOptions();
                options.WriteIndented = true;
                string json = JsonSerializer.Serialize<List<Person>>(personsBefore, options);
                using (StreamWriter streamWriter = new StreamWriter("data.json"))
                {
                    streamWriter.WriteLine(json);
                }
            }


            WriteLine("XML=====================");
            using (FileStream fs = new FileStream("data.xml", FileMode.Open))
            {
                personsAfter = xmlSerializer.Deserialize(fs) as List<Person>;
            }
            foreach (Person person in personsAfter)
            {
                WriteLine(person.Name);
            }

            WriteLine("JSON=====================");
            using (StreamReader fs = new StreamReader("data.json"))
            {
                personsAfter = JsonSerializer.Deserialize<List<Person>>(fs.ReadToEnd());
            }
            foreach (Person person in personsAfter)
            {
                WriteLine(person.Name);
            }

            ReadKey();
        }
    }
}
