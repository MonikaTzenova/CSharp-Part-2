using System;
using System.Text;
 
class AreaTriangle
{
    static void Main()
    {

        double bSide = double.Parse(Console.ReadLine());
        double hSide = double.Parse(Console.ReadLine());
 
        double area = (bSide * hSide) / 2;
        Console.WriteLine("{0:F2}", area);
    }
}
