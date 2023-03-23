using System;

namespace W3_T5
{
    internal class T5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nTask 5\n");
            Console.Write("Enter the radious of a circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * radius * radius;
            Console.WriteLine("\n\n");
            Console.Write("Area of this circle is: "+area);
            Console.WriteLine("\n\n");

        }
    }
}
