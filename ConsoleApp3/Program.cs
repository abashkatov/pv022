using static System.Console;

namespace ConsoleApp3
{
    interface A
    {
        void Print();
    }
    interface B
    {
        void Print();
    }
    interface C
    {
        void Print();
    }
    class Runnable : A, B, C
    {
        public void Print()
        {
            WriteLine("Runnable");
        }
        void A.Print()
        {
            WriteLine("A");
        }

        void B.Print()
        {
            WriteLine("B");
        }

        void C.Print()
        {
            WriteLine("C");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A r = new Runnable();
            r.Print();
            ReadKey();
        }
    }
}
