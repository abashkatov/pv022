using static System.Console;

namespace ConsoleApp3
{
    abstract class Person { 
        public string Name;
        public int Age;
        public bool hasAccess()
        {
            return false;
        }
        abstract public int GetNumber();
        public string GetSelf() {
            return "Person";
        }
        abstract public string GetThis();
        abstract public string GetBase();
    }
    class Employer: Person {
        public string Position;
        public new bool hasAccess() 
        {
            return true;
        }
        public override int GetNumber()
        {
            return 1;
        }
        public new string GetSelf()
        {
            return "Employer";
        }
        public override string GetThis()
        {
            return this.GetSelf();
        }
        public override string GetBase()
        {
            return base.GetSelf();
        }
    }
    sealed class Client: Person {
        public int CardNumber;

        public override int GetNumber()
        {
            return 2;
        }
        public new string GetSelf()
        {
            return "Client";
        }
        public override string GetThis()
        {
            return this.GetSelf();
        }
        public override string GetBase()
        {
            return base.GetSelf();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //object o = new Client();
            Client client = new Client();
            Person client2 = new Client();
            WriteLine(client.GetSelf());
            WriteLine(client2.GetSelf());

            if (client is Person)
            {
                WriteLine((client as Person).GetSelf());
                WriteLine(((Person)client).GetSelf());
            }

            Person[] persons = { client, new Employer() };

            foreach (Person person in persons) {
                person.hasAccess();
                string name = person.Name;
            }

            ReadKey();
        }
    }
}
