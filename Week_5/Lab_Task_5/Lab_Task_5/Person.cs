using System;

namespace Lab_Task_5
{
    class Person : Account
    {
        private string name;
        private string dob;

        public Person()
        {
            Console.Write("Enter your Name: ");
            string x = Console.ReadLine();
            name = x;
        }

        public Person(string name, string dob)
        {
            this.name = name;
            this.dob = dob;
        }

        public void setName(string name)
        { this.name = name; }

        public void setDob(string dob)
        { this.dob = dob; }

        public string getName()
        { return name; }

        public string getDob()
        { return dob; }
    }
}