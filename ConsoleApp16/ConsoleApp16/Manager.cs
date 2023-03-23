using System;

namespace ConsoleApp16
{
    class Manager : Employee
    {
        public int yearsOfExperience;

        public Manager(String id, String name, String address, int yearsOfExperience) : base(id, name, address)
        {
            this.yearsOfExperience = yearsOfExperience;
        }


        public override bool EmployeeStatus()
        {
            if (yearsOfExperience > 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}