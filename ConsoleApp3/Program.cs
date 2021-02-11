using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using static System.Console;

namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<IGrouping<bool, Person>> groups;
            Person[] persons = { 
                new Person("Name 1", 15, 170),
                new Person("Name 2", 17, 180),
                new Person("Name 3", 20, 190),
                new Person("Name 4", 22, 200),
                new Person("Name 5", 16, 160),
            };

            groups = from person in persons
                         //where person.Age > 18
                         //orderby person.Age
                     group person by person.Age > 18 into gr
                     where gr.Count() > 1
                     select gr
                     ;
                    //select person;


            foreach (IGrouping<bool, Person> group in groups) {
                string title = group.Key ? "adults" : "children";
                WriteLine("===" + title + "===");
                foreach (Person person in group) {
                    WriteLine(person.Name);
                }
            }

            ReadKey();
        }
    }
}
