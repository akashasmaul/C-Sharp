using System;

namespace _8_Feb_Class
{
    internal class Program
    {
        static void tTask()
        {
            Console.WriteLine("\nTask 1 :: Read and Print elements of an array: ");
            Console.WriteLine("-----------------------------------------");

            int[] arr = new int[10];
            Console.WriteLine("Input 10 elements in the array :");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("element - {0} : ", i+1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nElements in array are: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.Write("\n");
            Console.WriteLine("\nTask 2 :: Read number of values and print it in reverse order : ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("\nNumber of Values: "+ arr.Length);
            Console.Write("\nOriginal array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
            Console.Write("Array in reverse order: ");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
             Console.WriteLine("\nTask 3 ::  Find the sum of all elements in an array: ");
            Console.WriteLine("-----------------------------------------");
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];                
            }
            Console.WriteLine("");
            Console.Write("Sum of all element: " + sum);  
            Console.WriteLine("\n\n");
        }
        static void Marvel()
        {
            Console.WriteLine("Avengers");
        }
        static void Marvel(string name, int age)
        {
            Console.WriteLine("Hello " +name+". Your age is: " +age);
        }
        private static void Main(string[] args)
        {
            tTask();
            Console.WriteLine("\n");
            Marvel();
            Marvel("Peter Parker", 24);

       }
        }
}
