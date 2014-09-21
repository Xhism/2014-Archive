using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_LaptopShop
{
    class LaptopShop
    {
        static void Main(string[] args)
        {
            List<Laptop> laptops = new List<Laptop>
            {
                new Laptop("Lenovo Yoga 2 Pro", (decimal)2259.00, "Lenovo", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", 
                            "8 GB", "128GB SSD", "Intel HD Graphics 4400", new Battery("Li-Ion, 4-cells, 2550 mAh", (float)4.5), 
                            "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display"),
                new Laptop("HP 250 G2", (decimal)699),
            };
            foreach(Laptop laptop in laptops){
                Console.WriteLine(laptop.ToString());
            }
        }
    }
}
