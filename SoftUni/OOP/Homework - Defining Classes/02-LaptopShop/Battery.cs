using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_LaptopShop
{
    public class Battery
    {
        private string type;
        private float life;
        public Battery(string type)
        {
            this.Type = type;
        }
        public Battery(string type, float hours)
            : this(type)
        {
            this.Life = hours;
        }
        public string Type
        {
            get { return this.type; }
            set
            {
                if (value != null && value.Length < 1) throw new ArgumentException("Invalid value for battery type!");
                this.type = value;
            }
        }
        public float Life
        {
            get { return this.life; }
            set
            {
                if (value < 0) throw new ArgumentException("Battery life cannot be negative");
                this.life = value;
            }
        }
        public override string ToString()
        {
            StringBuilder resultStr = new StringBuilder();
            if (this.Type != null)
            {
                resultStr.AppendLine("battery: " + this.Type);
            }
            if (this.Life > 0)
            {
                resultStr.AppendLine("battery life: " + this.Life + " hours.");
            }
            return resultStr.ToString();
        }
    }
}
