using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IEnumerableExtensions
{
    public static class IEnumerableExt
    {
        public static T SumElemnt<T>(this IEnumerable<T> collection, Func<T, dynamic> projectToNumber)
        {
            if (collection.Count() == 0)
            {
                return default(T);
            }

            T sum = default(T);

            foreach (var item in collection)
            {
                sum += (dynamic)item;
            }

            return sum;

        }

        public static T MinElement<T>(this IEnumerable<T> collection)
           where T : IComparable
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("Collection is empty!");
            }

            T min = collection.First();

            foreach (var item in collection)
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }
            }

            return min;   
        }
        public static T Max<T>(this IEnumerable<T> collection) where T : IComparable
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("Collection is empty, could not indicate the min number!");
            }

            T max = collection.First();

            foreach (var item in collection)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }

            return max;
        }

        public static T AverageOf<T>(this IEnumerable<T> collection, Func<T, dynamic> projectToNumber)
        {
            double sum = 0;

            int elementsCount = 0;

            foreach (var item in collection)
            {
                sum += projectToNumber(item);
                elementsCount++;
            }

            return (dynamic) sum / (dynamic) elementsCount;
        }


    }
}
