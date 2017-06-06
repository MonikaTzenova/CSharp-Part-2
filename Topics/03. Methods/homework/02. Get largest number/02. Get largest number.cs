using System;


class GetMaxMethod
{
    static int GetMax(int numberOne, int numberTwo)
    {
        int bigNumber = numberOne;
        if (numberTwo > numberOne)
        {
            bigNumber = numberTwo;
        }

        return bigNumber;
    }

    static void Main()
    {
     string[] input = Console.ReadLine().Split(' ');
            int n1 = int.Parse(input[0]);  
            int n2 = int.Parse(input[1]);
      		int n3 = int.Parse(input[2]);

        int bigger = GetMax(n1, n2);

        Console.WriteLine(GetMax(bigger, n3));
    }
}
