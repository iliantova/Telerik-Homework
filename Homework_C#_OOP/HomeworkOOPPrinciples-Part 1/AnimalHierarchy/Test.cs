using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Test
    {
        static void Main()
        {
            Kitten[] newKitten = new Kitten[5];
            newKitten[0] = new Kitten("Lapichka", 5);
            newKitten[1] = new Kitten("Timiti", 1);
            newKitten[2] = new Kitten("Glezla", 3);
            newKitten[3] = new Kitten("Kotka", 2);
            newKitten[4] = new Kitten("Kitty", 10);

            Frog[] FrogsList = new Frog[3];
            FrogsList[0] = new Frog("Kvak", 1, false);
            FrogsList[1] = new Frog("Skoklio", 1, true);
            FrogsList[2] = new Frog("Krasaveca", 3, false);

            Dog[] newDog = new Dog[4];
            newDog[0] = new Dog("Rexy", 3, false);
            newDog[1] = new Dog("Tot", 4, false);
            newDog[2] = new Dog("Geya", 7, true);
            newDog[3] = new Dog("Ayay", 2, true);

            Console.WriteLine("Average age using standart calc: {0}", Animals.CalculateAverageLINQ(newKitten));
            Console.WriteLine("Average age using LINQ calc: {0}", Animals.CalculateAverageLINQ(newDog)); 

            Dog Sharo = new Dog("Sharo", 5, false);
            Console.WriteLine( "Sharo sais: " );
            Sharo.MakeSound();
        }
    }
}
