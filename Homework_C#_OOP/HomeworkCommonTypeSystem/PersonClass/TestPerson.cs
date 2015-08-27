using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    class TestPerson
    {
        static void Main()
        {

            var personFirst = new Person("Ivan Ivanov", 25);
            var personSecond = new Person("Nevena Nevenova");

            Console.WriteLine("{0}\n{1}", personFirst, personSecond);

        }
    }
}
