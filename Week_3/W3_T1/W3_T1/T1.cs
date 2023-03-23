using System;

namespace W3_T1
{
    internal class T1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nTask 1\n");
            Console.Write("Enter amount of USD you want to convert into BDT: ");
            double usd = Convert.ToDouble(Console.ReadLine());
            double taka = usd * 85.94;
            Console.Write("\n");
            Console.WriteLine(usd + " USD is currently equivalent to " + taka + " BDT.");
        }
    }
}
