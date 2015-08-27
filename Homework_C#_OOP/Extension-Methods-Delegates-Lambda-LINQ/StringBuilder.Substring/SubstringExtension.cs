using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StringBuilderSubstring
{
    public static class SubstringExtension
    {
        public static StringBuilder Substring(this StringBuilder builder, int index, int length)
        {
            if (index < 0 || length < 0 || (length + index)>builder.Length)
            {
                throw new ArgumentOutOfRangeException();
            }


            var substring = new StringBuilder();

            for (int i = index; i < length + index; i++)
            {
                substring.Append(builder[i]);
            }

            return substring;
        }

    }
}
