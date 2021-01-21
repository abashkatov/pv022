using ConsoleApp3.Model;
using static ConsoleApp3.Model.Person;
using static System.Console;

namespace ConsoleApp3
{
    class Program
    {
        /**
         * private
         * protected
         * protected internal
         * internal
         * public
         * */
        /**
         * static
         * const
         * readonly
         * */
        static void Main(string[] args)
        {
            Person 
                person = new Person("bbb")
            ;
            char[] chars = { 'g' };

            person.SetAge(1);

            person.SetName("sdfgsdg");
            person.SetName(chars);

            WriteLine(person.GetName());

            ReadKey();
        }
    }
}
