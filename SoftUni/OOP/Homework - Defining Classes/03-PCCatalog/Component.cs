using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_PCCatalog
{
    public abstract class Component
    {
        private string type;
        private string name;
        private string details;
        private decimal price;
        public Component(string name, decimal price, string details = null)
        {
            this.Name = name;
            this.Details = details;
            this.Price = price;
        }
        public string Type
        {
            get { return this.type; }
            set
            {
                this.type = value;
            }
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                if (null == value) throw new ArgumentNullException("Component name cannot be null");
                this.name = value;
            }
        }
        public string Details
        {
            get { return this.details; }
            set { this.details = value; }
        }
        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0) throw new ArgumentException("Component price cannot be negative!");
                this.price = value;
            }
        }
        public override string ToString()
        {
            string compToString = string.Format("{0}: {1}, Price: {2:C}", this.Type, this.Name, this.Price);
            if (null != this.Details)
            {
                compToString += string.Format(", Details: {0}", this.Details);
            }
            return compToString;
        }
    }
}
