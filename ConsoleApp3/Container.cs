using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Container
    {
        private List<string> services = new List<string>();
        public void AddSingleton(string Alias) {
            services.Add(Alias);
        }
    }
}
