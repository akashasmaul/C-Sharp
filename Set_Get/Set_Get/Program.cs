using System;

namespace Set_Get
{
    internal class Son
    {
        public Son()
        {
            Console.WriteLine("A");
        }
        public Son(int i)
        {
            Console.WriteLine("B" + i);
        }
        public Son(String j, int k) : this(k)
        {
            Console.WriteLine("C" + j);
        }
    }
    internal class Father : Son
    {
        public Father(int x) : this(x, "CNN")
        {
            Console.WriteLine("D" + x);
        }
        public Father(int x, String y) : base(y, x)
        {
            Console.WriteLine("E" + x);
        }
        public Father(String y) : this(20)
        {
            Console.WriteLine("F" + y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
          //  Son x = new Son();
            Son y = new Father(5);
        }
    }
}