using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Workers : Human
    {
        private int workDaysPerWeek = default(int);
        private double worksHoursPerDay = default(double);
        public double WeekSalary { get; set; }

        public Workers() { }
        public Workers(string firstName, string lastName):
            this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public Workers(string firstName, string lastName, double workHours, int workDays, double weekSalary) :
            this(firstName, lastName)
        {
            this.WorkHoursPerDay = workHours;
            this.WorkDaysPerWeek = workDays;
            this.WeekSalary = weekSalary;
        }

        public new string ToString()
        {
            return string.Format("Worker: {0} {1}, Week salary: {2}/{3:F2} per hour.",
                this.FirstName, this.LastName, this.WeekSalary, this.MoneyPerHour());
        }
        public double MoneyPerHour()
        {
            return WeekSalary / (WorkHoursPerDay * WorkDaysPerWeek);
        }



        public int WorkDaysPerWeek
        {
            get
            {
                return this.workDaysPerWeek;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Work days per week must be non-negative!");
                }
                this.workDaysPerWeek = value;
            }
        }
        public double WorkHoursPerDay
        {
            get
            {
                return this.worksHoursPerDay;
            }
            set
            {
                if (value > 24)
                {
                    throw new ArgumentOutOfRangeException("Work hours per day must be less than 24!");
                }
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Work hours per day must be non-negative!");
                }
                this.worksHoursPerDay = value;
            }
        }


    }
}
