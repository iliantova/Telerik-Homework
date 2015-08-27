using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64Bitarray
{
    class TetsBitArray
    {
        static void Main()
        {
            BitArray64 newBitArray00 = new BitArray64(786543u);
            BitArray64 newBitArray01 = new BitArray64(153245676854u);
            BitArray64 newBitArray02 = new BitArray64(4095u);
            Console.WriteLine("First value: {0}\nIn decimal: {1}", newBitArray00, BitArray64.ToDecimal(newBitArray00));
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Second value: {0}\nIn decimal: {1}", newBitArray01, BitArray64.ToDecimal(newBitArray01));
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Third value: {0}\nIn decimal: {1}", newBitArray02, BitArray64.ToDecimal(newBitArray02));
            Console.WriteLine("-------------------------------");
        }
    }
}
