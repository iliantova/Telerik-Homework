using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class DictionarySearch
    {
        static void Main()
        {
            Dictionary<string, string> WordTranslate =
    new Dictionary<string, string>();
            WordTranslate.Add(".NET", "platform for applications from Microsoft");
            WordTranslate.Add("CLR", "managed execution environment for .NET");
            WordTranslate.Add("namespace", "hierarchical organization of classes");

            Console.WriteLine("Enter word: ");
            string index = Console.ReadLine();
            if (WordTranslate.ContainsKey(index))
            {
                Console.WriteLine(WordTranslate[index]);
                Console.WriteLine();
            }
            else 
            {
                Console.WriteLine("This Word is not a part of the dictionary.");
            }

        }
    }

