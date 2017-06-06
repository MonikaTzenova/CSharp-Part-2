using System;
using System.Linq;

class FirstLargerThanNeighbours
{

    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        Console.WriteLine(FirstLargerThanNeighboursInArray(FromStringToIntArray()));
    }

    static int[] FromStringToIntArray()
    {
        string elementsInArray = Console.ReadLine();
        int[] arrayString = elementsInArray.Split().Select(n => Convert.ToInt32(n)).ToArray();
        return arrayString;
    }

    static int FirstLargerThanNeighboursInArray(int[] array)
    {
        int firstNeighboursIndex = 0;

        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                firstNeighboursIndex = i;
                break;
            }
            else
            {
                firstNeighboursIndex = -1;
            }
        }
        return firstNeighboursIndex;
    }
}
