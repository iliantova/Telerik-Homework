//Problem 7. Timer

//Using delegates write a class Timer that can execute certain method at each t seconds.




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProblemTimer
{
        public delegate void TimerDelegate();
    public class Timer
    {
        // fields
        private int interval;
        private int ticksCount;
        private TimerDelegate timerEvent;

        // constructor
        public Timer(int seconds, int ticksCount, TimerDelegate timerEvent)
        {
            this.Interval = seconds;
            this.TicksCount = ticksCount;
            this.TimerEvent = timerEvent;
        }

        // properties
        public int Interval
        {
            get
            {
                return this.interval;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Seconds cannot be below 0!");
                }
                this.interval = value * 1000;
            }
        }

        public int TicksCount
        {
            get
            {
                return this.ticksCount;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Ticks count cannot be below 0!");
                }
                this.ticksCount = value;
            }
        }

        public TimerDelegate TimerEvent
        {
            get
            {
                return this.timerEvent;
            }
            set
            {
                this.timerEvent = value;
            }
        }

        // Methods
        public void TickTack()
        {
            while (ticksCount > 0)
            {
                Thread.Sleep((int)interval);
                ticksCount--;
                timerEvent();
            }
        }
    }
}
