using System;

namespace ConsoleApp16

{
    abstract class Employee
    {
        public String id;
        public String name;
        public String address;

        public void ShowInfo()
        {
            Console.WriteLine("Employee ID: " + id);
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Employee Address: " + address);
            if (EmployeeStatus())
            {
                Console.WriteLine("Employee is eligible for bonus");
            }
            else
                Console.WriteLine("Employee is NOT eligible for bonus");
        }

        public Employee(String id, String name, String address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }
        public abstract bool EmployeeStatus();

    }
}