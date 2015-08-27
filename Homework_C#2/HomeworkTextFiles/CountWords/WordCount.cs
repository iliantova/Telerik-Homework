using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWords
{
    class WordCount
    {
            public WordCount(int intValue, string strValue)
            {
                Counter = intValue;
                Word = strValue;
            }

            public int Counter { get; set; }
            public string Word { get; set; }
    }
}
