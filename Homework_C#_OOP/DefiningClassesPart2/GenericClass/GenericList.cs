//Problem 5. Generic class

//Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
//Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
//Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, clearing the list, finding element by its value and ToString().
//Check all input parameters to avoid accessing elements at invalid positions.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class GenericList<T> where T : IComparable, IEnumerable<T>
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
        public override string ToString()
        {
            return string.Format("Number of elements in the list: {0}", this.COUNT);
        }

        /*
         * Method that adds a new element to the collection.
         */
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
                throw new IndexOutOfRangeException("Collection is full! Unable to add new element!");
            }
        }
        /*
         * Method that gets the index of the first appearance of an
         * element with a given value in the collection.
         */
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

        /*
         * Method that returns an element of the collection on a 
         * given position/index.
         */
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
        /*
         * Method that removes an element of the collection on a given position.
         */
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

        /*
         * Method that inserts an element in the collection on a given position.
         */
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

        /*
         * Method that clears the collection.
         */
        public void ClearList()
        {
            for (int i = 0; i < this.arrayList.Length; i++)
            {
                this.arrayList[i] = default(T);
            }
            this.count = 0;
            this.SIZE = 0;
        }

        /*
         * Public get and set properties.
         */
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
