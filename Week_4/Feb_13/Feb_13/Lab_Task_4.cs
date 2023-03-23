using System;

namespace Feb_13
{
    internal class Lab_Task_4
    {
        private static void tOne()
        {
            double x, fact = 1;
            Console.WriteLine("Task 1 :: Program to calculate the factorial of a given number.\n");
            Console.Write("Enter a number: ");
            x = Convert.ToDouble(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                fact = fact * i;
            }
            Console.Write("\tFactorial of " + x + " is: " + fact);
        }

        public static int Fibo(int nno)
        {
            int num1 = 0;
            int num2 = 1;

            for (int i = 0; i < nno; i++)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp + num2;
            }
            return num1;
        }

        private static void tTwo()
        {
            Console.WriteLine("Task 2 :: Program to display the n number Fibonacci sequence.\n");
            Console.Write("Enter number of Fibonacci Series : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\tThe Fibonacci series of " + n + " numbers is:\t");
            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibo(i) + "  ");
            }
        }

        private static void tThree()
        {
            Console.WriteLine("Task 3 :: Program to check whether a number is prime or not.\n");
            int n, i, m = 0, flag = 0;
            Console.Write("Enter the number: ");
            n = Convert.ToInt32(Console.ReadLine());
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("\tNumber " + n + " is not Prime.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.WriteLine("\tNumber " + n + " is Prime.");
        }

        private static void tFour()
        {
            Console.WriteLine("Task 4 :: Program to calculate the sum of the individual digits of a given number.\n");
            Console.Write("Enter a number: ");
            int d = Convert.ToInt32(Console.ReadLine());
            int sum = 0, m;
            while (d > 0)
            {
                m = d % 10;
                sum = sum + m;
                d = d / 10;
            }
            Console.Write("\tSum of the individual digits of the entered number: " + sum);
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("\n");
            tOne();
            Console.WriteLine("\n");
            tTwo();
            Console.WriteLine("\n");
            tThree();
            Console.WriteLine("\n");
            tFour();
            Console.WriteLine("\n");
        }
    }
}