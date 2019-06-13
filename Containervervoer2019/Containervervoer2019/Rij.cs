using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containervervoer2019
{
    public class Rij
    {
        private List<Container> Containers = new List<Container>();
        public double GewichtBovenDeBaseContainer { get; set; }
        public double BaseContainer { get; set; }
        public double TopVanRij { get; set; }

        public void AddContainer(Container container)
        {
            Containers.Add(container);
        }
        public List<Container> RijContainers()
        {
            return Containers;
        }
        public void RestList()
        {
            Containers.Clear();
        }

    }
}
