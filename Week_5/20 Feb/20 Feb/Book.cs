using System;

namespace _20_Feb
{
    class Book
    {
        public string title;
        public string author;
        public int pages;
        private string grade;

        public Book(string tTtile, string aAuthor, int aPages, string aGrade)
        {
            Console.WriteLine("\n\tConstructing Book\n");
            this.title = tTtile;
            this.author = aAuthor;
            this.pages = aPages;
            this.Grade = aGrade;
        }
        public string Grade
        {
            get
            {
                return grade;
            }
            set
            {
                if (value == "Good" || value == "Bad" || value == "Best")
                {
                    grade = value;
                }
                else
                {
                    grade = "Not Rated";
                }
            }
        }
    }
}
   