using System.Collections;
using static System.Console;

namespace ConsoleApp3
{
    class Days: IEnumerable, IEnumerator
    {
        int index = -1;

        public int[] GetDays() 
        {
            int[] days = { 1,2,3,4,5,6,7};

            return days;
        }

        public object Current => index + 1;
        public bool MoveNext()
        {
            index++;
            if (index < 7)
            {
                return true;
            }
            index = -1;
            return false;
        }

        public void Reset()
        {
            index = 0;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Days days = new Days();
            foreach (int day in days) 
            {
                WriteLine(day);
            }
            ReadKey();
        }
    }
}
