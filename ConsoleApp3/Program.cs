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
            List<Person> personsBefore = new List<Person>();
            personsBefore.Add(new Person("Name 1", 20, 180));
            personsBefore.Add(new Person("Name 2", 25, 180));

            List<Person> personsAfter = new List<Person>();

            foreach (Person person in personsBefore)
            {
                WriteLine(person.Name);
            }
            WriteLine("=====================");

            StringBuilder data = new StringBuilder();

            // Сериализация - реобразование данных в текст
            foreach (Person person in personsBefore)
            {
                data.Append(person.Name + "," + person.Age + "," + person.Height + "\n");
            }

            using (StreamWriter fs = new StreamWriter("data.txt")) {
                fs.WriteLine(data.ToString());
            }
            // ...
            string newData;
            using (StreamReader fs = new StreamReader("data.txt"))
            {
                newData = fs.ReadToEnd();
            }

            // Десериализация - восстановление данных из текста/потока байт
            /**
             * json
             * [
             *  {
             *      "Name": "Name 1",
             *      "Age": 20,
             *      "Height": 180
             *  },
             *  {
             *      "Name": "Name 2",
             *      "Age": 25,
             *      "Height": 180
             *  }
             * ]
             * xml
             * <xml>
             * <data>
             *  <List>
             *      <Person Name="Name 1" Age="20" Height="180"/>
             *      <Person>
             *          <Name>Name 1</Name>
             *          <Age>Name 1</Age>
             *          <Height>Name 1</Height>
             *      </Person>
             *  </List>
             * </data>
             * 
             * */

            string[] rawPersons = newData.Split('\n');
            foreach (string rawPerson in rawPersons)
            {
                string[] fileds = rawPerson.Split(',');
                if (fileds.Length != 3)
                {
                    continue;
                }
                //fileds[0] имя
                //fileds[1] возраст
                //fileds[2] рост
                personsAfter.Add(new Person(fileds[0], int.Parse(fileds[1]), int.Parse(fileds[2])));
            }

            foreach (Person person in personsAfter) {
                WriteLine(person.Name);
            }

            ReadKey();
        }
    }
}
