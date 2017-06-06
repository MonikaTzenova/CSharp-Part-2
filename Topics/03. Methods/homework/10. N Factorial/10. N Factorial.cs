using System;
using System.Numerics;

class NFactorial
{

    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
      
        CalculateNumberFacturial(number);
    }

    static void CalculateNumberFacturial(int number)
    {
        BigInteger factorial = 1;

        if (number < 0)
        {          
            return;
        }

        else if (number == 0 || number == 1)
        {
            Console.WriteLine(factorial);
            return;
        }
        else
        {
            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
            return;
        }
    }
}
