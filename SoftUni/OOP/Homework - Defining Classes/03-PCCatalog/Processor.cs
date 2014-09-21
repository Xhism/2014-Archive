using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_PCCatalog
{
    class Processor : Component
    {
        public Processor(string name, decimal price, string details = null)
            : base(name, price, details)
        {
            base.Type = "Processor";
        }
    }
}
