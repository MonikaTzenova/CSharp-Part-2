using System;

namespace _02.BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        { 
            string inputBinary = Console.ReadLine();
            long result = BinaryToDecimal(inputBinary);
            Console.WriteLine(result);
        }

        static long BinaryToDecimal(string inputBinary)
        {
            int digit = 0;
            int position = 0;
            long tempResult = 0;
            for (int i = 0; i < inputBinary.Length; i++)
            {
                digit = inputBinary[i] - '0'; 
                position = inputBinary.Length - i - 1;
                tempResult += digit * (long)Math.Pow(2, position);
            }
            return tempResult;
        }
    }
}
