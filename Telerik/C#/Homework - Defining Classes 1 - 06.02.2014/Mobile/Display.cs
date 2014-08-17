using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    public class Display
    {
        private int size;
        private long amountOfColors;

        //
        public int DisplaySize
        {
            get { return this.size; }
            set
            {
                if (size > 0)
                    this.size = value;
                else
                    throw new ArgumentOutOfRangeException("Invalid input: Display size needs to be more than 0!");
            }
        }

        public long AmountOfColors
        {
            get { return this.amountOfColors; }
            set { this.amountOfColors = value; }
        }
        //

        public Display()
        {
        }

        public Display(int size, long amountOfColors)
        {
            this.size = size;
            this.amountOfColors = amountOfColors;
        }
    }
}
