using System;
using System.Text;

namespace _01.DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        { 
            ulong inputDecimalNumb = ulong.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();
            DecimalToBinary(inputDecimalNumb, result);
            Console.WriteLine(result);
        }

        static void DecimalToBinary(ulong inputDecimalNumb, StringBuilder result)
        {
            ulong temp = 0;
            while (inputDecimalNumb != 0)
            {
                temp = inputDecimalNumb % 2;
                result.Append(temp);
                inputDecimalNumb = inputDecimalNumb / 2;
            }
            Reverse(result);
        }

        static void Reverse(StringBuilder result)
        {
            StringBuilder temp = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                temp.Append(result[result.Length - i - 1]);
            }
            result.Clear();
            result.Append(temp);
        }
    }
}
