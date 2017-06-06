using System;
using System.Linq;

namespace _04.AppearanceCount
{
    class Program
    {
        static int counter;

        static void Main(string[] args)
        { 
            int size = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int x = int.Parse(Console.ReadLine());
            CountingElements(size, arr, x);
            Console.WriteLine(counter);
        }

        static void CountingElements(int size, int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (x == arr[i])
                {
                    counter++;
                }
            }
        }
    }
}
