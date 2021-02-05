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
        List<IPart> walls = new List<IPart>();
        List<IPart> floors = new List<IPart>();
        int maxWall;
        int maxFloor;

        public Building(int maxWall, int maxFloor)
        {
            this.maxFloor = maxFloor;
            this.maxWall = maxWall;
        }

        public bool TryAddPart(IPart part) {
            if (part is Floor && floors.Count < maxFloor) {
                floors.Add(part);
                return true;
            }
            if (part is Wall && walls.Count < maxWall) {
                walls.Add(part);
                return true;
            }
            return false;
        }
        public ICollection<IPart> GetCurrentParts() {
            return new List<IPart>(parts);
        }
    }
}
