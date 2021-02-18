using ConsoleApp3.Entity;
using System;
using System.Collections.Generic;
using static System.Console;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Command
{
    class GetListCommand : ICommand
    {
        private readonly List<Person> persons;

        public GetListCommand(List<Person> persons)
        {
            this.persons = persons;
        }

        public string GetTitle()
        {
            return "Список пользователей";
        }

        public void Run()
        {
            Clear();
            foreach (Person person in persons)
            {
                WriteLine(person.Name);
            }
            ReadKey();
        }
    }
}
