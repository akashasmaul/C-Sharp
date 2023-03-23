using System;

namespace February_6_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {  /*
            Console.WriteLine("\nTask 1\n");
            Console.Write("Enter amount of USD you want to convert into BDT: ");
            double usd = Convert.ToDouble(Console.ReadLine());
            double taka = usd * 85.94;
            Console.Write("\n");
            Console.WriteLine(usd + " USD is currently equivalent to " + taka + " BDT.");
            Console.WriteLine("\n");

            Console.WriteLine("\nTask 2\n");
            int n;
            Console.Write("Enter the number you want to check: ");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            n = (int)d;
            if(n==d)
            {
                Console.WriteLine("Number is in Integer :: whole number.");
            }
            else
            {
                Console.WriteLine("Number is in float\\double :: not whole number.");
            }
            Console.WriteLine("\n");

            Console.WriteLine("\nTask 3\n");
            Console.Write("Enter first number: ");
            int num_1 = Convert.ToInt32 (Console.ReadLine());
            Console.Write("Enter second number: ");
            int num_2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nLarger number between "+num_1+ " and " +num_2+" is: ");
            Console.WriteLine(Math.Max(num_1, num_2));
            Console.WriteLine("\n");

            Console.WriteLine("\nTask 4\n");
            Console.Write("Enter first number: ");
            int num_3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num_4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nSmaller number between " + num_3 + " and " + num_4 + " is: ");
            Console.WriteLine(Math.Min(num_3, num_4));

            Console.WriteLine("\nTask 5\n");
            Console.Write("Enter the radious of a circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * radius * radius;
            Console.WriteLine("\n\n");
            Console.Write("Area of this circle is: "+area);
            Console.WriteLine("\n\n");   */
 /*
        Console.WriteLine("\n\n");
            int[] rollNumbers = { 4, 5, 7, 10, 500 };
            rollNumbers[0] = 450;
            Console.WriteLine(rollNumbers[0]);

            string[] friends = new string[3];
            friends[0] = "Pro";
            friends[1] = "Snake";
            friends[2] = "Player";
           // friends[3] = "AllMyFriendsAreToxic";
            Console.WriteLine(friends[0]);
*/

        Console.WriteLine("\n\n");
        int[] arr1= new int[5];  // 1D array
        arr1[0] = 2;
        arr1[1] = 20;
        arr1[2] = 200;
        arr1[3] = 2000;
        arr1[4] = 20000;
        arr1[5] = 200000;

        int[] arr2 = new int [4] {2,7,73,98};
        int[] arr3 = new int [] {2,7,73,98};


    // Multi Dimentional Array
    int[,] arr4 = new int [2, 3] {{1,2,3}, {4,5,6}};
    int[,] arr5 = new int [, ] {{1,2,3}, {4,5,6},{3.5,7}};

    int[,] arr6 = new int [2, 3];
    arr6[0,0] = 4;  //1st index 1st value
    arr6[1,3] = 4;  //2nd index 3rd value  || 2nd row, 3rd collum
        }
    }
}
