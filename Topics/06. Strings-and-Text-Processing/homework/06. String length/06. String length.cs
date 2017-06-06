using System;


namespace StringLenght
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            if (input.Length == 20) {
                Console.WriteLine(input);
            }
            else if (input.Length < 20) {
                Console.WriteLine(input.PadRight(20, '*'));
            }
        }
    }
}
