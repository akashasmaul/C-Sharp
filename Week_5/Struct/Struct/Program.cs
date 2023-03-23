using System;

namespace Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Books book1;

            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.subject = "Fantasy";
            book1.id = 34466;

            Console.WriteLine("The title of this book is {0} \nWritten by {1}", book1.title, book1.author);
        }

        struct Books  // User Defined variable
        {
            public string title;
            public string author;
            public string subject;
            public int id;
        };
    }

    public class Cal  // polymorphism: method overloading
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Add(int a, int b, int c) // changing the parameter
        {
            return a + b + c;
        }
        public static float Add(float a, float b) // changing the datatype
        {
            return a + b;
        }
    }


}
