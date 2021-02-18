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
using System.Xml;
using System.Text.RegularExpressions;
using ConsoleApp3.Model;
using ConsoleApp3.Command;
using ConsoleApp3.Entity;

namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Перерыв до 20-15
            List<Person> persons = new List<Person>();
            persons.Add(new Person($"Old Name {persons.Count + 1}", 20));
            //persons.Add(new Person($"Name {persons.Count + 1}", 20));
            //persons.Add(new Person($"Name {persons.Count + 1}", 20));
            //persons.Add(new Person($"Name {persons.Count + 1}", 20));
            //persons.Add(new Person($"Name {persons.Count + 1}", 20));
            //persons.Add(new Person($"Name {persons.Count + 1}", 20));
            //persons.Add(new Person($"Name {persons.Count + 1}", 20));

            List<AbstractCommand> commands = new List<AbstractCommand>();
            commands.Add(new GetListCommand(persons));
            commands.Add(new SaveToFileCommand(persons));
            commands.Add(new LoadFromFileCommand(persons));


            Menu menu = new Menu(commands);
            menu.Run();

            //ReadKey();
        }
    }
}
