using System;
using System.Collections.Generic;
using System.Numerics;

namespace Solution
{
    public enum SentanceType
    {
        Question,
        Statement
    }

    public class Program
    { 
        public static void Main()
        {
            var word = Console.ReadLine();
            var linesCount = int.Parse(Console.ReadLine());
            var lines = new List<string>();

            for (int line = 0; line < linesCount; line++)
            {
                lines.Add(Console.ReadLine());
            }

            var text = string.Join(" ", lines);

            var wordIndex = text.IndexOf(word);
            var sentanceBegining = -1;
            var sentanceEnd = -1;

            for (int index = wordIndex; index > 0; index--)
            {
                if (text[index] >= 65 && text[index] <= 90)
                {
                    sentanceBegining = index;
                    break;
                }
            }

            SentanceType? sentanceType = null;

            for (int index = wordIndex + word.Length; index < text.Length; index++)
            {
                if (text[index] == '.')
                {
                    sentanceEnd = index;
                    sentanceType = SentanceType.Statement;
                    break;
                }

                if (text[index] == '!')
                {
                    sentanceEnd = index;
                    sentanceType = SentanceType.Question;
                    break;
                }
            }

            string targetSubstring = string.Empty;

            if (sentanceType == SentanceType.Statement)
            {
                targetSubstring = text.Substring(wordIndex + word.Length, sentanceEnd - (wordIndex + word.Length));
            }
            else
            {
                targetSubstring = text.Substring(sentanceBegining, wordIndex - sentanceBegining);
            }
            
            var gluedSubstring = targetSubstring.Replace(" ", string.Empty);
            BigInteger result = 0;

            foreach (var character in gluedSubstring)
            {
                result += character * word.Length;
            }


            Console.WriteLine(result);
        }
    }
}

/*
tell
3
How do you tell html from html5? Try
it out in internet explorer. Did it
work? No? It's html5.

will
4
Software developers like to solve 
problems. If they are no problems
handily available, they will create
their own problems.


Sentances will always start with a capital letter and will end with a dot.
There will not be more than 10 sentances, situated along no more than 15 lines.
Each sentance will not contain more than 50 words. 

    The provided word will never be in the begining or the end of a sentance.
    The provided word will never be contained inside another word.

*/
