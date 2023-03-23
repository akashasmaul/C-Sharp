using System;

namespace Interface
{
    internal interface Ride
    {
        void changeGear(int a);

        void speedUp(int a);

        void speedDown(int a);
    }

    internal class Tesla : Ride
    {
        private int gear;
        private int speed;

        public void changeGear(int gearChange)
        {
            gear = gearChange;
        }

        public void speedDown(int speedDec)
        {
            speed = speed - speedDec;
        }

        public void speedUp(int speedInc)
        {
            speed = speed + speedInc;
        }

        public void shiwInfo()
        {
            Console.WriteLine("Gear: {0}\nSpeed: {1}", gear, speed);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine();
            Class1 c1 = new Class1();
            c1.cookRice();
            c1.makeSalad();
            Console.WriteLine("\n");

            Tesla ob = new Tesla();
            ob.changeGear(2);
            ob.speedUp(40);
            ob.speedDown(2);
            Console.WriteLine("The information regarding the car is given below: ");
            ob.shiwInfo();
        }
    }
}