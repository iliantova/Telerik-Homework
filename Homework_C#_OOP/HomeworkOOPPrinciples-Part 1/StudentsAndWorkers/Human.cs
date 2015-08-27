using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
   abstract class Human
    {

      private string firstName;
      private string lastName;

      public override string ToString()
      {
          return string.Format("Human Name: {0} {1}", this.FirstName, this.LastName);
      }

      public string FirstName
      {
          get
          {
              return this.firstName;
          }
          set
          {
              this.firstName = value;
          }
      }
      public string LastName
      {
          get
          {
              return this.lastName;
          }
          set
          {
              this.lastName = value;
          }
      }



    }
}
