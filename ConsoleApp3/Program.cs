using ConsoleApp3.Service;
using System;
using System.Collections;
using static System.Console;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceProvider serviceProvider = new ServiceProvider();
            serviceProvider.AddSingleton(typeof(A).FullName);
            serviceProvider.AddSingleton<B>();

            A a = serviceProvider.GetService<A>();

            ReadKey();
        }
    }
}
