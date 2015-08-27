using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensions
{
    class TestExt
    {
        static void Main()
        {
            var hardCodedNums = new int[] { 1, 6, -3, 4, 8, -10, 0, 15, -100 };
            var hardCodedNames = new string[] { "Pesho", "Gosho", "Tosho", "Ivan", "Penka" };

            Console.WriteLine("Min: {0}, {1}", hardCodedNames.Min(), hardCodedNums.Min());
            Console.WriteLine("Max: {0}, {1}", hardCodedNames.Max(), hardCodedNums.Max());
            Console.WriteLine("Average: {0}, {1}", hardCodedNames.Average(x => x.Length), hardCodedNums.Average(x => x));
            Console.WriteLine("Sum: {0}, {1}", hardCodedNames.SumElemnt(x => x), hardCodedNums.SumElemnt(x => x));
        }
    }
}
