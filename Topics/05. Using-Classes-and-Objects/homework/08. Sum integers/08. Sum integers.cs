using System;
using System.Linq;

class SumInteger
{

    static void Main()
    {
        string numbers = Console.ReadLine();
        int[] splitNumbers = StringFunction.SplitBySpace(numbers);
        int sum = StringFunction.Sum(splitNumbers);
        Console.WriteLine(sum);
    }
}

static class StringFunction
{

    public static int[] SplitBySpace(string numbers)
    {
        int[] splitNumbers = numbers.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
        return splitNumbers;
    }

    public static int Sum(int[] numbers)
    {
        int sum = 0;
        foreach (var item in numbers)
        {
            sum += item;
        }
        return sum;
    }
}
