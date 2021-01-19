using System;
using System.Text;
using static System.Console;

namespace ConsoleApp3
{
    enum Days:short { Monday = 0, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday}
    enum Days1 { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday}
    enum Days2 { Monday, Tuesday=5, Wednesday, Thursday=15, Friday, Saturday, Sunday}
    class Program
    {
        static void Main(string[] args)
        {
            //string currentDay = "Monday";

            //string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Sturday", "Sunday" };
            //short currentDay = 1;

            Random rnd = new Random();
            Array enumValues = Enum.GetValues(typeof(Days));

            foreach (Object day in enumValues) {
                WriteLine((Days)day + " = " + (short)day);
            }

            string currentDay = "Monday";

            WriteLine(Days.Wednesday + " = " + (short)Days.Wednesday);
            WriteLine(Days.Wednesday == Days.Sunday);

            string value = Enum.GetName(Days.Wednesday.GetType(), 8);
            if (value == null)
            {
                WriteLine("value is null");
            }
            else { 
                WriteLine("Value: " + value);
            }

            WriteLine(Enum.IsDefined(Days.Wednesday.GetType(), currentDay));

            ReadKey();
        }
    }
}
