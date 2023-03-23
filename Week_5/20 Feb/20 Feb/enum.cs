using System;

namespace _20_Feb
{
    internal class @enum
    {
        internal enum Planet  // if number is not assigned then it is considered as Index of array
        {
            Mercury = 1,
            Venus = 2,
            Earth = 3,
            Mars = 4,
            Jupiter = 5,
            Saturn = 7,
            Neptune = 8,
            Pluto = 9
        }

        private static void Main(string[] args)
        {
            Console.WriteLine(Planet.Earth.ToString() + " is planet number: " + (int)Planet.Earth);

            Book book1 = new Book("Harry Potter", "JK Rawling", 365, "Good"); //class object creation
            Console.WriteLine("Title: " + book1.title + "\nAuthor: " + book1.author + "\nPages: " + book1.pages + "\nRating: " + book1.Grade);

            Book book2 = new Book("Game of Thrones", "George Raymond Martin", 1675, "Best"); //class object creation
            Console.WriteLine("Title: " + book2.title + "\nAuthor: " + book2.author + "\nPages: " + book2.pages+ "\nRating: "+book2.Grade);
        }
    }
}