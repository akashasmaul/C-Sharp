using System;

namespace Lab_Task_5
{
     class Employee : Person
    {
         Account acc = new Account();

        public Employee()
        {
            
        }
    public Employee(string name, string dob, Account acc)
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
            Console.WriteLine("\t\t\nEmployee Information\n\n");
            Console.Write("Name: {0} \nDate of Birth: {1} \nAccount ID: {2} \nAccount Type: {3}", getName(), getDob(), getAccID(), getAccType());
        }


    }
}
