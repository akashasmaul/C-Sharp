using System;

namespace W3_T4
{
    internal class T4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nTask 4\n");
            Console.Write("Enter first number: ");
            int num_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num_2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nSmaller number between " + num_1 + " and " + num_2 + " is: ");
            Console.WriteLine(Math.Min(num_1, num_2));
        }
    }
}
