using System;

namespace TheoryTask3_3
{
    internal class T_T_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nTask 3 ::  Find the sum of all elements in an array: ");
            Console.WriteLine("-----------------------------------------");
            int[] arr = new int[] { 123, 234, 345, 456, 567, 678, 789, 890 };
            Console.Write("\nArray: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];                
            }
            Console.WriteLine("\n\n");
            Console.Write("Sum of all element: " + sum);
            Console.WriteLine("\n\n");
        }
    }
    
}
