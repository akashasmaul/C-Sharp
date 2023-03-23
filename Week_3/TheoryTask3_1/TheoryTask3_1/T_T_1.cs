using System;

namespace TheoryTask3_1
{
    internal class T_T_1
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("\nTask 1 :: Read and Print elements of an array: ");
            Console.WriteLine("-----------------------------------------");

            int[] arr = new int[10];
            Console.WriteLine("Input 10 elements in the array :");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nElements in array are: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.Write("\n");
        }
    }
}