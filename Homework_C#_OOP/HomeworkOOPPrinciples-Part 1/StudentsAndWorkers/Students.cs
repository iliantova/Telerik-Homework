using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Students : Human
    {
         private double grade = default(double);

        public Students() { }

        public Students(string firstName, string lastName):
            this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public Students(string firstName, string lastName, double grade): 
            this(firstName, lastName)
        {
            this.Grade = grade;
        }

        public new string ToString()
        {
            return string.Format("Student: {0} {1}, Grade: {2}",
                this.FirstName, this.LastName, this.Grade);
        }
        public double Grade
            {
            get
            {
                return this.grade;
            }
            set
            {
                if (value > 6) { throw new ArgumentOutOfRangeException("Grade must be 6 or less!"); }
                if (value < 2) { throw new ArgumentOutOfRangeException("Grade must be more dann 2!"); }
                this.grade = value;
            }
        }
    }
}
