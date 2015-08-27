//Problem 12. Call history test

//Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
//Create an instance of the GSM class.
//Add few calls.
//Display the information about the calls.
//Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
//Remove the longest call from the history and calculate the total price again.
//Finally clear the call history and print it.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallHistoryTest
{
    class Calls : IComparable<Calls>
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

        public int CompareTo(Calls otherCall)
        {
            if (this.DURATION > otherCall.DURATION)
            {
                return 1;
            }
            else if (this.DURATION == otherCall.DURATION)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        //Override ToString() method.
        //Note that if the call duration is zero we output the call just like a Click.
        public override string ToString()
        {
            if (this.DURATION == 0)
            {
                return string.Format("Clicked: {0} in {1} at {2}.",
                    this.DIALLEDPN, this.DATE.ToShortDateString(), this.TIME.ToString(@"hh\:mm\:ss"));
            }
            else
            {
                return string.Format("Called: {0} in {1} at {2}. Duration: {3} seconds.",
                    this.DIALLEDPN, this.DATE.ToShortDateString(), this.TIME.ToString(@"hh\:mm\:ss"), this.DURATION);
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
