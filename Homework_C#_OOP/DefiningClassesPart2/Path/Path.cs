//Problem 4. Path

//Create a class Path to hold a sequence of points in the 3D space.
//Create a static class PathStorage with static methods to save and load paths from a text file.
//Use a file format of your choice.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Path
{
    [Serializable()]
   public class Path
    {

       private List<Point3D> pathHolder = new List<Point3D>();

       public List<Point3D> PATH
       {
           get
           {
               return this.pathHolder;
           }
       }

       public override string ToString()
       {
           StringBuilder builder = new StringBuilder();
           foreach (var point in PATH)
           {
               builder.Append(point.ToString());
               builder.Append(" ");
           }
           builder.AppendLine();
           return builder.ToString();
       }

       public void AddPoint (Point3D point)
       {
          this.pathHolder.Add(point);
       }



    }
}
