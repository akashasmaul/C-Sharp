using System;

namespace TheoryTask3_2
{
    internal class T_T_2
    {
        private static void Main(string[] args)

        {
            Console.WriteLine("\nTask 2 :: Read number of values and print it in reverse order : ");
            Console.WriteLine("-----------------------------------------");
            int[] arr = new int[] { 123, 234, 345, 456, 567, 678, 789, 890 };
            Console.WriteLine("\nNumber of Values: "+ arr.Length);
            Console.Write("\nOriginal array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n\n");
            

            Console.Write("Array in reverse order: ");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n\n");
        }
    }
}