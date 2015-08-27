//Problem 5. 64 Bit array

//Define a class BitArray64 to hold 64 bit values inside an ulong value.
//Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64Bitarray
{
    class BitArray64 : IEnumerable<int>
    {
        private const byte SIZE = 64;
        private ulong numberValue;
        public ulong BITVALUE
        {
            get { return this.numberValue; }
            set { this.numberValue = value; }
        }
        private BitArray64() { }
        public BitArray64(ulong number) :
            this()
        {
            this.BITVALUE = number;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < SIZE; i++)
            {
                yield return this[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override bool Equals(object obj)
        {
            var otherBitArray = obj as BitArray64;
            return this.BITVALUE.Equals(otherBitArray.BITVALUE);
        }
        public override int GetHashCode()
        {
            return this.BITVALUE.GetHashCode() ^ SIZE ^ 243;
        }
        public byte this[int index]
        {
            get
            {
                if (index < 0 || index >= SIZE)
                {
                    throw new
                        ArgumentOutOfRangeException("Index out of range!");
                }
                return (byte)((this.BITVALUE >> index) & 1);
            }
            set
            {
                if (index < 0 || index >= SIZE)
                {
                    throw new
                        ArgumentOutOfRangeException("Index out of range!");
                }
                if (value < 0 || value > 1)
                {
                    throw new
                        ArgumentException("Argument must be either 1 or 0!");
                }
                if (((int)(this.BITVALUE >> index) & 1) != value)
                {
                    this.BITVALUE ^= (1ul << index);
                }
            }
        }
        public static bool operator ==(BitArray64 arr1, BitArray64 arr2)
        {
            return arr1.Equals(arr2);
        }
        public static bool operator !=(BitArray64 arr1, BitArray64 arr2)
        {
            return !(arr1.Equals(arr2));
        }

        public override string ToString()
        {
            StringBuilder resultBitArray = new StringBuilder();
            for (int index = 0; index < 64; index++)
            {
                resultBitArray.Insert(0, ((this.BITVALUE >> index) & 1));
            }
            return resultBitArray.ToString();
        }
        public static ulong ToDecimal(BitArray64 bitArray)
        {
            return Convert.ToUInt64(bitArray.ToString(), 2);
        }

    }
}
