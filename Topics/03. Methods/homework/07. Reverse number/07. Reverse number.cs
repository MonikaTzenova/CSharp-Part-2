using System;

class ReverseNumber
{

    static void Main()
    {
        string number = Console.ReadLine();
        Console.WriteLine(ReverseDecimalNumber(number));
    }

    static string ReverseDecimalNumber(string number)
    {     
        char[] arr = number.ToCharArray();
        Array.Reverse(arr);
        string numberToString = new string(arr);
   
        return numberToString;
    }
}
