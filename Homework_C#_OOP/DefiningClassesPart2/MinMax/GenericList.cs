
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
    class GenericList<T> where T : IComparable
    {
        private T[] arrayList = null;
        private T value = default(T);
        private int index = 0;
        private int size = 0;
        private int count = 0;

        public GenericList() { }

        public GenericList(int size)
        {
            this.count = 0;
            this.SIZE = size;
            arrayList = new T[this.SIZE];
        }

     
        public static T Max(GenericList<T> source)
        {
            T max = default(T);
            max = source.arrayList[0];
            for (int i = 0; i < source.arrayList.Length; i++)
            {
                if (max.CompareTo(source.arrayList[i]) <= 0)
                {
                    max = source.arrayList[i];
                }
            }
            return max;
        }

     
        public static T Min(GenericList<T> source)
        {
            T min = default(T);
            min = source.arrayList[0];
            for (int i = 0; i < source.arrayList.Length; i++)
            {
                if (min.CompareTo(source.arrayList[i]) >= 0)
                {
                    min = source.arrayList[i];
                }
            }
            return min;
        }


    
        public static T[] Clone(T[] sourceArray, T[] destinationArray)
        {
            if (destinationArray.Length < sourceArray.Length)
            {
                throw new IndexOutOfRangeException("Destination array is smaller than the source array!");
            }
            else
            {
                for (int i = 0; i < sourceArray.Length; i++)
                {
                    destinationArray[i] = sourceArray[i];
                }

                return destinationArray;
            }
        }

        public static T[] Resize(T[] sourceArray)
        {
            T[] resultArray = new T[sourceArray.Length * 2];
            GenericList<T>.Clone(sourceArray, resultArray);
            return resultArray;
        }

        public override string ToString()
        {
            return string.Format("Number of elements in the list: {0}", this.COUNT);
        }

     
        public void Add(T element)
        {
            if (this.COUNT < this.arrayList.Length)
            {
                this.arrayList[COUNT] = element;
                this.count++;
                this.SIZE++;
            }
            else if (this.COUNT >= this.arrayList.Length)
            {
                this.arrayList = GenericList<T>.Resize(this.arrayList);
                this.arrayList[COUNT] = element;
                this.count++;
                this.SIZE++;
            }
        }
   
        public int GetByValue(T element)
        {
            bool flag = true;
            int i = 0;
            int index = -1;
            while (flag && i < this.arrayList.Length)
            {
                if (this.arrayList[i].CompareTo(element) == 0)
                {
                    flag = false;
                    index = i;
                }
                i++;
            }
            if (flag)
            {
                return -1;
            }
            else
            {
                return index;
            }
        }

    
        public T GetAtIndex(int index)
        {
            this.INDEX = index;
            if (this.INDEX >= this.arrayList.Length)
            {
                return default(T);
            }
            else if (this.INDEX > this.COUNT)
            {
                return default(T);
            }
            else
            {
                return this.arrayList[this.INDEX];
            }
        }
     
        public void RemoveAtIndex(int index)
        {
            this.INDEX = index;
            if (this.INDEX < this.arrayList.Length && this.INDEX <= this.COUNT)
            {
                this.arrayList[this.INDEX] = default(T);
                int i = this.INDEX;
                while (i <= this.COUNT - 1)
                {
                    this.arrayList[i] = this.arrayList[i + 1];
                    i++;
                }
                this.SIZE--;
                this.count--;
            }
        }

    
        public void InsertAtIndex(int index, T element)
        {
            this.INDEX = index;
            if (this.INDEX > this.arrayList.Length - 1)
            {
                throw new IndexOutOfRangeException("Unable to insert at index! Index is outside of range!");
            }
            else if (this.INDEX >= this.COUNT)
            {
                this.arrayList[INDEX] = element;
                do
                {
                    this.count++;
                } while (this.INDEX >= this.COUNT);
                this.SIZE++;
            }
            else if (this.INDEX < this.COUNT && this.COUNT + 1 < this.arrayList.Length)
            {
                this.count++;
                this.SIZE++;
                int tempFlag = this.COUNT;
                do
                {
                    this.arrayList[tempFlag] = this.arrayList[tempFlag - 1];
                    tempFlag--;
                } while (tempFlag >= this.INDEX);
                this.arrayList[this.INDEX] = element;
            }
        }

      
        public void ClearList()
        {
            for (int i = 0; i < this.arrayList.Length; i++)
            {
                this.arrayList[i] = default(T);
            }
            this.count = 0;
            this.SIZE = 0;
        }

       
        public int SIZE
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }
        public int INDEX
        {
            get
            {
                return this.index;
            }
            set
            {
                this.index = value;
            }
        }
        public int COUNT
        {
            get
            {
                return this.count;
            }
        }
        public T VALUE
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }
    }
}
