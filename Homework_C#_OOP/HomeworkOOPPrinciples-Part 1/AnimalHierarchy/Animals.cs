using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    abstract class Animals // We connot create new animal (maybe with genetic engineering) 
    {
       private int age = default(int);
       private string name = string.Empty;
       private bool isFemale = default(bool);




       public static double CalculateAverageLINQ(Animals[] animalArray)
       {
           var result = (from animal in animalArray
                         select animal.Age).Average();

           return result;
       }


          public string Name
        {
            get
            {
                return this.name;
            }
         protected set
            {
                this.name = value;
            }
        }
          public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The age must be non - negativ value");
                }
                else
                {
                    this.age = value;
                }
            }
        }
        
        public bool Sex
        {
            get
            {
                return this.isFemale;
            }
            protected set
            {
               this.isFemale = value;
            }
        }
       
     }
}
