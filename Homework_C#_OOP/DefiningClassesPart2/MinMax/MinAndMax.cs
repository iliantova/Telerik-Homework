//Problem 7. Min and Max
// Create generic methods Min<T>() and Max<T>() for finding the
// minimal and maximal element in the GenericList<T>.
// You may need to add a generic constraints for the type T.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class MinAndMax
    {
        static void Main()
        {
            GenericList<int> list = new GenericList<int>(10);
            for (int i = 0; i < 6; i++)
            {
                list.Add(i);
            }
            Console.WriteLine(list.ToString());
            Console.WriteLine("List state after initialization: ");
            for (int i = 0; i < list.COUNT; i++)
            {
                Console.Write("{0} ", list.GetAtIndex(i));
            }

            list.RemoveAtIndex(2);
            Console.WriteLine("\nList state after removing element at index {0}: ", list.INDEX);
            for (int i = 0; i < list.COUNT; i++)
            {
                Console.Write("{0} ", list.GetAtIndex(i));
            }

            list.InsertAtIndex(7, 13);
            Console.WriteLine("\nList state after inserting element at index {0}: ", list.INDEX);
            for (int i = 0; i < list.COUNT; i++)
            {
                Console.Write("{0} ", list.GetAtIndex(i));
            }

            list.Add(14);
            Console.WriteLine("\nList state after adding an element: ");
            for (int i = 0; i < list.COUNT; i++)
            {
                Console.Write("{0} ", list.GetAtIndex(i));
            }

            list.Add(99);
            Console.WriteLine("\nList state after adding another element: ");
            for (int i = 0; i < list.COUNT; i++)
            {
                Console.Write("{0} ", list.GetAtIndex(i));
            }

            Console.WriteLine("\n" + list.ToString());

            Console.WriteLine("MAX: {0}", GenericList<int>.Max(list));
            Console.WriteLine("MIN: {0}", GenericList<int>.Min(list));

            Console.WriteLine(list.GetAtIndex(list.GetByValue(4)));
        }
    }
}
