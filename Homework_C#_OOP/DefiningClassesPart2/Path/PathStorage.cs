//Problem 4. Path

//Create a class Path to hold a sequence of points in the 3D space.
//Create a static class PathStorage with static methods to save and load paths from a text file.
//Use a file format of your choice.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Path
{
     [Serializable()]
   public static class PathStorage
    {
    
       public static void SavePath(Path path)
            {
                try
                {
                    using (Stream stream = File.Open("pathdata.bin", FileMode.Create))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        bin.Serialize(stream, path);
                    }
                }
                catch (IOException)
                {
                }
            }

            public static Path LoadPath()
            {
                Path path = new Path();
                try
                {
                    using (Stream stream = File.Open("pathdata.bin", FileMode.Open))
                    {
                        BinaryFormatter bin = new BinaryFormatter();

                        path = (Path)bin.Deserialize(stream);
                    }
                }
                catch (IOException)
                {
                }
                return path;
            }
        }
}
