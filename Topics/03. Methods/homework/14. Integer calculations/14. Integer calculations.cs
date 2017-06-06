using System;
using System.Linq;


class IntegerCalculations
{

    static void Main()
    {
        int[] inputArray = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
        MinMaxAverageSumProduct(inputArray);
    }

    static void MinMaxAverageSumProduct(int[] array)
    {
        long product = 1;

        Console.WriteLine(array.Min());
        Console.WriteLine(array.Max());
        Console.WriteLine("{0:F2}",array.Average());
        Console.WriteLine(array.Sum());

        foreach (var item in array)
        {
            product *= item;
        }
        Console.WriteLine(product);
    }
}
