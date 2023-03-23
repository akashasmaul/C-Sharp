using System;

namespace ConsoleApp16
{
    class ServiceProvider
    {
        static List<Employee> employees = new List<Employee>();

        internal static void Inset(Employee z)
        {
            employees.Add(z);
        }

        internal static void ProvideDetails()
        {
            Console.WriteLine("Details");
            for (int i = 0; i < employees.Count; i++)
            {
                Employee x = employees[i];
                x.ShowInfo();
            }
        }

        internal static void SkilledWorker()
        {
            Console.WriteLine("Skilled");
            for (int i = 0; i < employees.Count; i++)
            {
                Employee v = employees[i];
                if (v.GetType() == typeof(Laborer))
                {
                    Laborer l = (Laborer)v;
                    if (l.userRating > 80)
                    {
                        v.ShowInfo();
                    }
                }
            }
        }
    }
}