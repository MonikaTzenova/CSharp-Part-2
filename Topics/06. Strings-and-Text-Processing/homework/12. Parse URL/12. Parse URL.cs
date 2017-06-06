using System;

class ParseURL
{
    static void Main(string[] args)
    {
        string URL = Console.ReadLine();

        string protocol = URL.Substring(0, URL.IndexOf(':', 0));

        int firstIndex = URL.IndexOf(':', 0) + 3;
        int secondIndex = URL.IndexOf('/', firstIndex);

        string server = URL.Substring(firstIndex, secondIndex - firstIndex);
        string resource = URL.Substring(secondIndex);

        Console.WriteLine("[protocol] = " + protocol);
        Console.WriteLine("[server] = " + server);
        Console.WriteLine("[resource] = " + resource);

        Console.WriteLine();
    }
}
