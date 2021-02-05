using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Wall : IPart
    {
        public string GetName()
        {
            return "Построена стена";
        }
    }
}
