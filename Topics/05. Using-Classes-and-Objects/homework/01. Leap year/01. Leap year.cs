using System;
 
namespace forgetCode
{
    class Program
    {
        static void Main()
        {
            int year = Convert.ToInt32(Console.ReadLine());
            
            if (DateTime.IsLeapYear(year))
            {
            Console.WriteLine("Leap");   
            }
            
            else
                Console.WriteLine("Common");                          
        }
 
    }
}
