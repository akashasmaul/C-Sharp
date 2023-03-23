using System;

namespace Quiz_Calcu
{
    internal interface CalcuInter
    {
        abstract void Addition(double x, double y);

        abstract void Subtract(double x, double y);

        abstract void Multiply(double x, double y);

        abstract void Divide(double x, double y);
    }

    internal interface Scientific
    {
        abstract void Power(double x, double y);

        abstract void Root(double x);
    }

    internal class Implementation : CalcuInter, Scientific
    {
        public double add, sub, mul, div, pow, root;

        public void Addition(double x, double y)
        {
            add = (x + y);
        }

        public void Subtract(double x, double y)
        {
            sub = x - y;
        }

        public void Multiply(double x, double y)
        {
            mul = x * y;
        }

        public void Divide(double x, double y)
        {
            div = x / y;
        }

        public void Power(double x, double y)
        {
            pow = Math.Pow(x, y);
        }

        public void Root(double x)
        {
            root = Math.Sqrt(x);
        }

        public void ShowInfo()
        {
            Console.WriteLine("Addition: " + add);
            Console.WriteLine("Subtraction: " + sub);
            Console.WriteLine("Multiply: " + mul);
            Console.WriteLine("Division: " + div);
            Console.WriteLine("Power: " + pow);
            Console.WriteLine("Square Root: " + root);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Implementation cal = new Implementation();
            cal.Addition(5, 3);
            cal.Subtract(5, 3);
            cal.Multiply(5, 3);
            cal.Divide(10, 2);
            cal.Power(5, 2);
            cal.Root(144);
            cal.ShowInfo();
        }
    }
}