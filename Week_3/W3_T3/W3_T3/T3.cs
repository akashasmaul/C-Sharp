using System;

namespace W3_T3
{
    internal class T3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nTask 3\n");
            Console.Write("Enter first number: ");
            int num_1 = Convert.ToInt32 (Console.ReadLine());
            Console.Write("Enter second number: ");
            int num_2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nLarger number between "+num_1+ " and " +num_2+" is: ");
            Console.WriteLine(Math.Max(num_1, num_2));


        }
    }
}
