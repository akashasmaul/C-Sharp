using System;

namespace _22_02_2022
{
    internal class Chef
    {
        public void makeChicken() 
            {
            Console.WriteLine("Chicken is cooked!");
        }
        public void makeSalad()
        {
            Console.WriteLine("Salad is cooked!");
        }
        public virtual void makeSpecialDish()
        {
            Console.WriteLine("Biriyani is cooked!");
        }
    }
}
