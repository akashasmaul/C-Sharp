using System;

namespace Interface
{
    internal class Class1 : Interface1, Interface2
    {
        public void cookRice()
        {
            Console.WriteLine("Welcome to the Rice Field");
            // throw new NotImplementedException(); // because no proper implementation was found
        }

        public void makeSalad()
        {
            Console.WriteLine("Salad is made");
        }
    }
}