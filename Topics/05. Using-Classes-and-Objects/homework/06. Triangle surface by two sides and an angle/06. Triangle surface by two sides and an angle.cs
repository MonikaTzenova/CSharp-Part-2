using System;
using System.Text;
 
class SurfaceThreeSides
{
    static void Main()
    {

        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double angle = double.Parse(Console.ReadLine());


        double surface = (a * b * Math.Sin(Math.PI * angle / 180)) / 2;
        Console.WriteLine("{0:F2}", surface);
    }
}
