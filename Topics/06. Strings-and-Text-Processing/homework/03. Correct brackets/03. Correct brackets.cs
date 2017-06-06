using System;

namespace CorrectBrackets
{
    class Program
    {

        static void Main()
        {

            string input = Console.ReadLine();
            Console.WriteLine(Check(input));
        }
        static string Check(string s)
        {
            int openSlash = 0;
            int closeSlash = 0;
            char[] arr = s.ToCharArray();
            foreach (char symbol in arr) {
                if (symbol == '(') {
                    openSlash++;
                }
                else if (symbol == ')') {
                    closeSlash++;
                }
            }

            if (openSlash == closeSlash)
            {
                return "Correct";
            }
            else {
                return "Incorrect";
            }

        }
    }
}
