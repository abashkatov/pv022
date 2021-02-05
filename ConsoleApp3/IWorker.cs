using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    interface IWorker
    {
        void DoWork(Building building, Queue<IPart> parts);
    }
}
