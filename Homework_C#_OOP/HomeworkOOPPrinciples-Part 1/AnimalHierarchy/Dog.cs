using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Dog : Animals, ISound
    {
        public Dog(string name, int age, bool Isfemale)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = Isfemale;
        }

        public void MakeSound()
        {
            Console.WriteLine("BAY");
        }

    }
}
