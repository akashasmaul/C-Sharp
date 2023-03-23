using System;

namespace Void
{
    internal class Human    // internal
    {
        internal int age, nid;
        internal string name, nationality;

        public Human()
        { }

        public Human(int age, int nid, string name, string nationality)
        {
            this.age = age;
            this.nid = nid;
            this.name = name;
            this.nationality = nationality;
            Console.WriteLine(this.name);
            Console.WriteLine(this.age);
            Console.WriteLine(this.nationality);
            Console.WriteLine(this.nid);
        }

        internal void displayDetails()
        {
            Console.WriteLine(this.name);
            Console.WriteLine(this.age);
            Console.WriteLine(this.nationality);
            Console.WriteLine(this.nid);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Demo class!");
            Human santo = new Human(23, 11111, "Santo", "Bangladeshi");
            santo.displayDetails();
            Human umme = new Human(23, 11121, "Umme Rifat", "Bangladeshi");
            umme.displayDetails();
            Human arpon = new Human(24, 12232312, "Arpon", "Bangladeshi");
            Human tanim = new Human();
            tanim.name = "tanim";
        }
    }
}