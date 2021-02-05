using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Building
    {
        List<IPart> parts = new List<IPart>();
        public void AddPart(IPart part) {
            parts.Add(part);
        }
        public ICollection<IPart> GetCurrentParts() {
            return new List<IPart>(parts);
        }
    }
}
