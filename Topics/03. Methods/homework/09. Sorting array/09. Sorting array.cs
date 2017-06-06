using System;
using System.Linq;

class SortingArray
{

    static void Main()
    {
        int[] array = InputData();

        int[] sortArray = SortArray(array);

        PrintAnswer(sortArray);
    }

    static int[] InputData()
    {
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];

        string arrayAsString = Console.ReadLine();
        array = arrayAsString.Split().Select(n => Convert.ToInt32(n)).ToArray();

        return array;
    }

    static int[] SortArray(int[] array)
    {
        Array.Sort(array);
        return array;
    }

    static void PrintAnswer(int[] sortArray)
    {
        foreach (var item in sortArray)
        {
            Console.Write(item + " ");
        }
    }
}
