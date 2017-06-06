using System;
using System.Text;

class ReplaceIdenticalLetter
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();

        StringBuilder sb = new StringBuilder();
        char letter = text[0];

        for (int i = 1; i < text.Length; i++)
        {
            char nextLetter = text[i];

            if (letter != nextLetter)
            {
                sb.Append(letter);
                letter = nextLetter;
            }
            if (i == text.Length - 1)
            {
                sb.Append(nextLetter);
            }
        }
        Console.WriteLine(sb);
    }
}
