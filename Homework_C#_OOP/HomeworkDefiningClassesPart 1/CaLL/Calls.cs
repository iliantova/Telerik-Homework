//Problem 8. Calls

//Create a class Call to hold a call performed through a GSM.
//It should contain date, time, dialled phone number and duration (in seconds).


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaLL
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

        public override string ToString()
        {
            if (this.DURATION == null)
            {
                return string.Format("Clicked: {0} in {1} at {2}.",
                    this.DIALLEDPN, this.DATE, this.TIME);
            }
            else
            {
                return string.Format("Called: {0} in {1} at {2}. Duration: {3} seconds.",
                    this.DURATION, this.DATE, this.TIME, this.DURATION);
            }
        }

    }
}
