
//Problem 2. Gravitation on the Moon

//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.



using System;



class MoonWeight
{
    static void Main()
    {

        Console.WriteLine("Write a weight:");
        float EarthWeight = float.Parse(Console.ReadLine());
        float MoonWeight = (17 * EarthWeight) / 100;
        Console.WriteLine(MoonWeight);


    }
}
