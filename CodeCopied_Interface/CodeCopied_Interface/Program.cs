using System;

namespace CodeCopied_Interface
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Calculator cal = new Calculator();

            Console.WriteLine("Addition: " + cal.addition(5, 3));
            Console.WriteLine("Subtraction: " + cal.subtract(5, 3));
            Console.WriteLine("Multiply: " + cal.multiply(5, 3));
            Console.WriteLine("Division: " + cal.divide(10, 2));

            Console.WriteLine("Power: " + cal.power(5, 2));
            Console.WriteLine("Square Root: " + cal.root(144));
        }
    }
}