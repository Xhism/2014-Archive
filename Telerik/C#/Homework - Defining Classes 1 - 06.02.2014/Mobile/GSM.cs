using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{

    // BATTERY TYPE ENUM



    // CLASS GSM

    public class GSM
    {
        static GSM IPhone4s = new GSM("Apple", "4S");
        private string manufacturer;
        private string model;
        private double? price;
        private string ownerName;
        public Battery battery = new Battery();
        public Display display = new Display();
        private static List<Call> callHistory = new List<Call>();


        //
        public string Model
        {
            get { return model; }
            set { this.model = value; }
        }
        public string Manufacturer
        {
            get { return manufacturer; }
            set { this.manufacturer = value; }
        }
        public double? Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Invalid input: price must be at least 0!");
                else
                    this.price = value;
            }

        }
        //

        // GSM CONSTRUCTORS
        public GSM()
        {
        }

        public GSM(string manufacturer, string model, string ownerName)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.ownerName = ownerName;
            this.price = 0;
        }

        public GSM(string manufacturer, string model, double price)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.price = price;
            this.ownerName = null;
        }

        public GSM(string manufacturer, string model, double price, string ownerName)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.price = price;
            this.ownerName = ownerName;
        }

        public GSM(string manufacturer, string model)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.price = null;
            this.ownerName = null;
        }

        public GSM(string manufacturer, string model, double price, string ownerName, string battery, long hoursIdle, long hoursTalk, int displaySize, long displayColors)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.price = price;
            this.ownerName = ownerName;
            this.battery.BatteryModel = battery;
            this.battery.HoursIdle = hoursIdle;
            this.battery.HoursTalk = hoursTalk;
            this.display.DisplaySize = displaySize;
            this.display.AmountOfColors = displayColors;
        }
        public GSM IPhone4S
        {
            get { return IPhone4s; }
        }
        // END GSM CONSTRUCTORS

        // CALL HISTORY OPERATIONS
        public List<Call> CallHistory
        {
            get { return callHistory; }
        }

        public void AddCallInHistory(Call call)
        {
            callHistory.Add(call);
        }
        public bool DeletingCallFromHistory(Call call)
        {
            for (int i = 0; i < callHistory.Count; i++)
            {
                if (callHistory[i].Date == call.Date &&
                    callHistory[i].Time == call.Time &&
                    callHistory[i].DialedPhoneNumber == call.DialedPhoneNumber &&
                    callHistory[i].Duration == call.Duration)
                {
                    callHistory.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public void ClearHistory()
        {
            callHistory.Clear();
        }
        public decimal CallPrice(decimal pricePerMinute)
        {
            decimal sum = 0;
            foreach (var item in callHistory)
            {
                sum += (decimal)item.Duration;
            }
            return sum * pricePerMinute;
        }

        //Override ToString()
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Model: " + model);
            sb.Append("\nManufacturer: " + manufacturer);
            if (price != 0)
            {
                sb.Append("\nPrice: " + price);
            }
            else
            {
                sb.Append("\nPrice: " + "N/A");
            }

            sb.Append("\nOwner: " + ownerName);
            sb.Append("\nDisplay size: " + display.DisplaySize);
            sb.Append("\nDisplay number of colors: " + display.AmountOfColors);
            sb.Append("\nBattery hours idle: " + battery.HoursIdle);
            sb.Append("\nBattery hours talk: " + battery.HoursTalk);
            sb.Append("\nBattery model: " + battery.BatteryModel);
            string testStr = sb.ToString();
            return testStr;
        }
    }


}
