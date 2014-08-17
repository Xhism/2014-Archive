using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    enum BatteryType
    {
        Null, LiIon, NiMH, NiCd, RandomBatteryModel,
    }

    public class Battery
    {
        private string batteryModel;
        private long hoursIdle;
        private long hoursTalk;

        //
        public long HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value >= 0)
                    this.hoursIdle = value;
                else
                    throw new ArgumentOutOfRangeException("Invalid Input: Idle hours need to be a non-negative value!");
            }
        }
        public long HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value >= 0)
                    this.hoursTalk = value;
                else
                    throw new ArgumentOutOfRangeException("Invalid Input: Talk hours need to be a non-negative value!");
            }
        }
        public string BatteryModel
        {
            get { return this.batteryModel; }
            set { this.batteryModel = value; }
        }
        //

        public Battery()
        {
        }

        public Battery(string model, long hoursIdle, long hoursTalk)
        {
            this.batteryModel = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }
    }


}
