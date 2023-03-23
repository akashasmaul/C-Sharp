using System;

namespace Task_2
{
    internal class lab_two
    {
        static void Main(string[] args)
        {   Console.Write("\n\n");
            Console.Write("\tEnter first number: ");
            double one = Convert.ToDouble (Console.ReadLine());
            Console.Write("\tInput second number: ");
            double two = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine();
            Console.Write("Summation of "+one+" and "+two+" is: ");
            Console.WriteLine(one + two);
            Console.Write("Subtraction of "+one+" and "+two+" is: ");
            Console.WriteLine(one - two);
            Console.Write("Multiplication of "+one+" and "+two+" is: ");
            Console.WriteLine(one * two);
            Console.Write("Divison of "+one+" and "+two+" is: ");
            Console.WriteLine((double)one / two);
            Console.Write("\n\n");

        }
    }
}
