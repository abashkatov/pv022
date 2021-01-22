using static System.Console;

namespace ConsoleApp3
{
    class Program
    {
        // Перерыв до 20:34
        #region задание
        class Foo
        {
            public int value = 1;
        }
        static int ChangeInt(int n)
        {
            n++;
            return n;
        }
        static Foo ChangeFoo(Foo foo)
        {
            foo.value++;
            return foo;
        }
        #endregion
        #region int
        static void WithValue(int i)
        {
            i = 10;
        }
        #endregion
        #region ref int
        static void WithValueRef(ref int i)
        {
            i = 10;
        }
        #endregion
        #region Foo
        static void WithReference(Foo foo)
        {
            foo.value = 10;

            foo = new Foo();
            foo.value = 200;
        }
        #endregion
        #region ref Foo
        static void WithReferenceRef(ref Foo foo)
        {
            foo.value = 10;

            foo = new Foo();
        }
        #endregion
        static void Main(string[] args)
        {
            int i = 1;
            Foo foo1 = new Foo(), foo2 = foo1;

            WriteLine(foo1.value); // 1
            foo1.value++;
            WriteLine(foo2.value); // 2

            //WithValue(i);
            //WithValueRef(ref i);
            WithReferenceRef(ref foo1);

            WriteLine(foo1.value); // 1
            WriteLine(foo2.value); // 10

            ReadKey();
        }
    }
}
