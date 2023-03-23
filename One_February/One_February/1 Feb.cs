using System;

namespace One_February
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*   Console.WriteLine( "\n\n");
Console.WriteLine( 2.2 * 9.54); //data type চিনতে পারে 
Console.WriteLine( 2.2 * 9); //can calculate 2 diff data type
Console.WriteLine( 5 / 2); //can not give exact ans. shows data type :: integer 
Console.WriteLine( 5.00 / 2); // to get in float
                 Console.WriteLine( "\n\n");   */
            //math fuction
            /*    Console.WriteLine( "\n\n");
Console.WriteLine(Math.Pow(2, 3)); // 2 is base ,, 3 is power
Console.WriteLine(Math.Pow(2.3, 5) ); //can use exact decimal value
Console.WriteLine(Math.Sqrt(36)); //square root
Console.WriteLine(Math.Max(20,88)); //shows maximum
Console.WriteLine(Math.Min(20,88)); //shows minumum
Console.WriteLine(Math.Round(45.7645656)); //round it to the neartest integer
Console.WriteLine(Math.Round(4.5));
               Console.WriteLine( "\n\n");   */
            //user input
            Console.WriteLine("\n\n");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("\n");
            Console.WriteLine("Hello " + name);
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine()); //convert korte hobe cause Readline() always takes string
            Console.Write("\n");
            Console.WriteLine("Hello " + name + ". Your age is: " + age);
            Console.WriteLine("\n\n");
        }
    }
}
