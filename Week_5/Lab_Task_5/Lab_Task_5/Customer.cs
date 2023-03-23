using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_5
{
    class Customer : Employee
    {
        Account acc = new Account();

        public Customer()
        {

        }
        public Customer(string name, string dob, Account acc)
        {
            setName(name);
            setDob(dob);            
        }
        public void setAcc(Account acc)
        {
            this.acc = acc;
        }
        public void display()
        {
            Console.WriteLine("\t\t\nCustomer Information\n\n");
            Console.WriteLine("Name: {0} \nDate of Birth: {1} \nAccount ID: {2} \nAccount Type: {3}", getName(), getDob(), getAccID(), getAccType());
        }
    }
}
