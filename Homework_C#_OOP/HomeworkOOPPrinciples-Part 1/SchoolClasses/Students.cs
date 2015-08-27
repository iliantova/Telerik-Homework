using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
   class Students : People, ISchool
    {

       public Guid ClassNumber { get; private set; }
       

        public Students(string name, Guid number)
        {
            base.Name = name;
            this.ClassNumber = number;
         
        }

        public string GetComment()
        {
            return string.Format("This is a comment to the Student class!");
        }

        public override string ToString()
        {
            return string.Format("{0} number: {1}", Name, ClassNumber);
        }
    }
}
