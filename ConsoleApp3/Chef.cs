using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Chef: IWorker
    {
        public void DoWork(Building building, Queue<IPart> parts)
        {
            if (building.GetCurrentParts().Count == 0) {
                WriteLine("Ещё ничего не построено");
            }
            WriteLine("Уже построено:");
            foreach (IPart part in building.GetCurrentParts())
            {
                WriteLine(part.GetName());
            }
            if (parts.Count == 0) {
                WriteLine("Дом готов к сдаче в эксплуатацию!");
            }
        }
    }
}
