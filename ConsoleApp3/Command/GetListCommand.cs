using ConsoleApp3.Entity;
using System;
using System.Collections.Generic;
using static System.Console;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Command
{
    class GetListCommand : AbstractCommand
    {
        private readonly List<Person> persons;

        public GetListCommand(List<Person> persons)
        {
            this.persons = persons;
        }

        public override string GetTitle()
        {
            return "Список пользователей";
        }

        public override void Run()
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
