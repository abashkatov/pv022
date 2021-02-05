using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Builder : IWorker
    {
        public void DoWork(Building building, Queue<IPart> parts)
        {
            if (parts.Count == 0) {
                WriteLine("Ошибка! У меня кончились материалы.");
                return;
            }
            IPart part = ((Queue<IPart>)parts).Dequeue();
            building.AddPart(part);
        }
    }
}
