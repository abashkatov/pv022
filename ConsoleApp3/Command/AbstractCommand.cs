using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Command
{
    abstract class AbstractCommand : ICommand
    {
        public abstract string GetTitle();
        public abstract void Run();

        public override string ToString()
        {
            return GetTitle();
        }
    }
}
