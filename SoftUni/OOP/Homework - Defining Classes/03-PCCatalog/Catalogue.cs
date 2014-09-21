using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_PCCatalog
{
    class Catalogue
    {
        static void Main(string[] args)
        {
            Component vcardGeForce = new GraphicCard("GeForce", (decimal)123.45, "Not worth it.");
            Component mboardVLC = new Motherboard("VLC", (decimal)567.89);
            Component procIntel = new Processor("Intel", (decimal)123.45);
            Component vcardRadeon = new GraphicCard("Radeon", (decimal)456.78);
            Component procAMD = new Processor("AMD", (decimal)345.67, "Always the best.");
            Computer compAMDRadeon = new Computer("Almost new", new List<Component>() { mboardVLC, vcardRadeon, procAMD });
            Computer compIntelGeForce = new Computer("Old");
            compIntelGeForce.Components.Add(vcardGeForce);
            compIntelGeForce.Components.Add(mboardVLC);
            compIntelGeForce.Components.Add(procIntel);
            List<Computer> computers = new List<Computer>() { compAMDRadeon, compIntelGeForce };
            computers.OrderBy(c => c.Price).ToList().ForEach(c => Console.WriteLine(c.ToString()));
        }
    }
}
