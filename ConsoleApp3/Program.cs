using static System.Console;

namespace ConsoleApp3
{
    abstract class BaseEntity 
    {
        public string publicString = "publicString BaseEntity";
        protected string protectedString = "BaseEntity";
        private string privateString = "privateString";
    }
    abstract class BasePerson: BaseEntity {
        public new string publicString = "publicString BasePerson";
        protected new string protectedString = "BasePerson";
        protected string ProtectedString {
            get => base.protectedString;
        }
    }
    abstract class Person: BasePerson { 
        public string Name;
        public int Age;
        public bool hasAccess()
        {
            return false;
        }
        abstract public int GetNumber();
        public virtual string GetSelf() {
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
        public override string GetSelf()
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
    class Client: Person {
        public int CardNumber;
        private string newPrivateString = "";
        private string privateString = "";
        //protected new string protectedString = "Client";
        public void PrintProtectedString() {
            //WriteLine(protectedString);
            //WriteLine(base.protectedString);
            //protectedString = "";
            var t = this;
            t.protectedString = "";
            var t1 = t;
            t1.protectedString = "";
            //t.publicString
            WriteLine(ProtectedString);
        }
        public override int GetNumber()
        {
            return 2;
        }
        public override string GetSelf()
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
            // Перерыв до 
            //object o = new Client();
            Client client = new Client();
            Person client2 = new Client();
            client.PrintProtectedString();
            //WriteLine(client.GetSelf());
            //WriteLine(client2.GetSelf());

            //if (client is Person)
            //{
            //    WriteLine((client as Person).GetSelf());
            //    WriteLine(((Person)client).GetSelf());
            //}

            Person[] persons = { client, new Employer() };

            foreach (Person person in persons) {
                //WriteLine(person.GetSelf());
                //string name = person.Name;
            }

            ReadKey();
        }
    }
}
