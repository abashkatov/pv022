using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Command
{
    class ExitCommand : ICommand, IPrintable
    {
        public bool CanExecute(string cmd)
        {
            return cmd == "3";
        }

        public string Execute(ref bool IsStop)
        {
            IsStop = true;
            return "";
        }
        public override string ToString()
        {
            return "3. Выход";
        }
    }
}
