using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderSubstring
{
    class SubstringExtensionMain
    {
        static void Main()
        {
            StringBuilder testExt = new StringBuilder();
            testExt.Append("test1");
            testExt.Append("test2");
            testExt.Append("test3");
           StringBuilder rezult = testExt.Substring(5, 5);
           Console.WriteLine(rezult);

            
        }
    }
}
