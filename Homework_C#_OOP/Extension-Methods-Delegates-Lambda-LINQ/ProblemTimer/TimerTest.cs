//Problem 7. Timer

//Using delegates write a class Timer that can execute certain method at each t seconds.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTimer
{
    class TimerTest
    {
        static void Main()
        {
            Timer myTimer = new Timer(1, 10, delegate() { Console.WriteLine("A new event has occured, oh joy !"); });
            myTimer.TickTack();

        }
    }
}
