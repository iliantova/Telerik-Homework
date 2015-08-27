//Problem 11. Version attribute

//Create a [Version] attribute that can be applied to structures, classes, interfaces,
//enumerations and methods and holds a version in the format major.minor (e.g. 2.11).
//Apply the version attribute to a sample class and display its version at runtime.


using System;
using System.Linq;
using System.Reflection;

namespace VersionAttribute
{
    [Versions(Versions.ComponentType.Class, "TestVerson", "2.11")]
    class TestVerson
    {
        
        static void Main()
        {

            var attr = typeof(TestVerson).GetCustomAttributes<Versions>();
            foreach (var attribute in attr)
            {
                Console.WriteLine("{0}: {1} Version: {2}.{3}",
                attribute.Component, attribute.Name, attribute.MajorVersion, attribute.MinorVersion);
            }
        }
    }

}
