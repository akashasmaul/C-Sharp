
using System;

namespace ConsoleApp16
{
    class Program
    {
        private static void Main(string[] args)
        {
            ServiceProvider.Inset(new Manager("PM-01", "Shuvo", "Uttara", 5));
            ServiceProvider.Inset(new Manager("PM-02", "Jahid", "Badda", 1));
            ServiceProvider.Inset(new Laborer("PL-001", "Sohan", "Mirpur", 85, 20));
            ServiceProvider.Inset(new Laborer("PL-002", "Jisan", "Kuril", 65, 44));
            ServiceProvider.Inset(new Laborer("PL-003", "Numan", "Banani", 88, 3));
            //Manager(id,name,address,yearsOfExperience)
            //Laborer(id,name,address,userrating,noOfServices)
            ServiceProvider.ProvideDetails();
            ServiceProvider.SkilledWorker();
        }
    }
}