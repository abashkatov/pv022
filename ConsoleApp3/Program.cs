using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using static System.Console;

namespace ConsoleApp3
{

    class Program
    {
        static void Main(string[] args)
        {
            List<IWorker> workers = new List<IWorker>();
            var chief = new Chief();
            workers.Add(chief);
            workers.Add(new Builder());
            workers.Add(new Builder());
            workers.Add(new Builder());
            workers.Add(new Builder());
            workers.Add(new Builder());
            Queue<IPart> parts = new Queue<IPart>();
            parts.Enqueue(new Floor());
            parts.Enqueue(new Floor());
            parts.Enqueue(new Floor());
            parts.Enqueue(new Floor());
            parts.Enqueue(new Floor());
            parts.Enqueue(new Wall());
            parts.Enqueue(new Wall());
            parts.Enqueue(new Wall());
            parts.Enqueue(new Wall());
            parts.Enqueue(new Wall());
            parts.Enqueue(new Wall());
            parts.Enqueue(new Wall());
            parts.Enqueue(new Wall());
            Building building = new Building();

            do {
                foreach (IWorker worker in workers) {
                    worker.DoWork(building, parts);
                }
            } while (parts.Count > 0);

            chief.DoWork(building, parts);

            ReadKey();
        }
    }
}
