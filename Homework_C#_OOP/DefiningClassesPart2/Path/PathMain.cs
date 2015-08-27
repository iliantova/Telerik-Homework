//Problem 4. Path

//Create a class Path to hold a sequence of points in the 3D space.
//Create a static class PathStorage with static methods to save and load paths from a text file.
//Use a file format of your choice.

using System;
using System.Collections.Generic;

namespace Path
{
    class PathMain
    {
        static void Main()
        {

            Point3D x = new Point3D(1, 1, 1);
            Point3D y = new Point3D(2, 2, 2);
            Point3D z = new Point3D(3, 3, 3);
            Path newPath = new Path();
            newPath.AddPoint(x);
            newPath.AddPoint(y);
            newPath.AddPoint(z);
            Console.WriteLine("Path before serialization:");
            Console.WriteLine(newPath.ToString());

            PathStorage.SavePath(newPath);
            Path list = PathStorage.LoadPath();
            Console.WriteLine("Path after deserialization:");
            Console.WriteLine(newPath.ToString());
        }
    }
}
