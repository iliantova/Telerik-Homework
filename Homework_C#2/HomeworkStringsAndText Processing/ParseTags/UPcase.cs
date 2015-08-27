//Problem 5. Parse tags

//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested.
//Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class UPcase
    {
        public static void test(string string1, ref string result)
        {
            string toFind1 = "<upcase>";
            string toFind2 = "</upcase>";
            if (string1.Length > 0)
            {
                if (string1.Contains(toFind1))
                {
                    int start = string1.IndexOf(toFind1) + toFind1.Length;
                    int end = string1.IndexOf(toFind2);
                    result += string1.Substring(0, start- toFind1.Length);
                    result += string1.Substring(start, end-start).ToUpper();
                    test(string1.Substring(end + toFind2.Length), ref result);
                }
                else
                {
                    result += string1;
                }
            }
        }

        static void Main()
        {
            Console.WriteLine("Please enter a string:");
            string string1 = Console.ReadLine();
            string result = "";
            test(string1, ref result);
            Console.WriteLine(result);

        }
    }

