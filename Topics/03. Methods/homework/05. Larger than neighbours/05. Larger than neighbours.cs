using System;
using System.Linq;

namespace _05.LargerThanNeighbours
{
    class Program
    {
        static int counter;

        static void Main(string[] args)
        { 
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            CheckNeighbours(n, arr);
            Console.WriteLine(counter);
        }

        static void CheckNeighbours(int n, int[] arr)
        {
            for (int i = 1; i < n - 1; i++)
            {
                if (arr[i - 1] < arr[i] && arr[i] > arr[i + 1])
                {
                    counter++;
                }
            }
        }
    }
}
