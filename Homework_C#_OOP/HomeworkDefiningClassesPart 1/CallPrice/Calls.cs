//Problem 11. Call price

//Add a method that calculates the total price of the calls in the call history.
//Assume the price per minute is fixed and is provided as a parameter.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallPrice
{
    class Calls
    {
        private DateTime date = DateTime.Now;
        private TimeSpan time = TimeSpan.MinValue;
        private string dialledPN = null;
        private int? duration = null;

        public DateTime DATE
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }

        public TimeSpan TIME
        {
            get
            {
                return this.time;
            }
            set
            {
                this.time = value;
            }
        }

        public string DIALLEDPN
        {
            get
            {
                return this.dialledPN;
            }
            set
            {
                this.dialledPN = value;
            }
        }

        public int? DURATION
        {
            get
            {
                return this.duration;
            }
            set
            {
                this.duration = value;
            }
        }

        public Calls()
        {
        
        }

        public Calls(DateTime date, TimeSpan time, string dialledPN, int? duration)
        {
            this.DATE = date;
            this.TIME = time;
            this.DIALLEDPN = dialledPN;
            this.DURATION = duration; 
        }


    }
}
