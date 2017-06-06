using System;

class MethodExample
{
    static void PrintName(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }

    static void Main()
    {
      
        string name = Console.ReadLine();
        PrintName(name);
    }
}
