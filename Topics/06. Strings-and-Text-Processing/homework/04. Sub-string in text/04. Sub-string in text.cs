using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sub_string_in_text
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine();
            string inputSentence = Console.ReadLine();
            Console.WriteLine(SubStringInText(pattern, inputSentence));
        }

        static int SubStringInText(string pattern, string inputSentence)
        {
            int counter = 0;
            int i = 0;
            while ((i = inputSentence.IndexOf(pattern, i, StringComparison.CurrentCultureIgnoreCase)) != -1)
            {
                counter++;
                i++;
            }
            return counter;
        }
    }
}
