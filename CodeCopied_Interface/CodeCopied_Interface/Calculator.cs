using System;

namespace CodeCopied_Interface
{
    internal class Calculator : BasicCal, ScientificCal
    {
        public int addition(int x, int y)
        {
            return x + y;
        }

        public int subtract(int x, int y)
        {
            return x - y;
        }

        public int multiply(int x, int y)
        {
            return x * y;
        }

        public int divide(int x, int y)
        {
            return (x / y);
        }

        public double power(int x, int y)
        {
            return Math.Pow(x, y);
        }

        public double root(int x)
        {
            return Math.Sqrt(x);
        }
    }
}