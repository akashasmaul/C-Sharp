using System;

namespace ConsoleApp16

{
    class Laborer : Employee
    {
        public int userRating;
        public int chargePerService = 500;
        public int noOfServices;

        public Laborer(String id, String name, String address, int userRating, int noOfServices) : base(id, name, address)
        {
            this.userRating = userRating;
            this.noOfServices = noOfServices;
        }

        public override bool EmployeeStatus()
        {
            if (userRating > 70 && noOfServices >= 10)
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