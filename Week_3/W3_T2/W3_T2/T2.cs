using System;
using System.Linq;

namespace W3_T2
{
    internal class T2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nTask 2\n");
            int n;
            Console.Write("Enter the number you want to check: ");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            n = (int)d;
            if(n==d)
            {
                Console.WriteLine("Number is in Integer :: whole number.");
            }
            else
            {
                Console.WriteLine("Number is in float\\double :: not whole number.");
            }
        }
        
    }
}
