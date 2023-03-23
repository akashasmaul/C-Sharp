using System;

namespace Lab_Task_5
{
    class Account
    {
        private int account_id;
        private double amount;
        private string accType;

        public Account()
        {
            Console.Write("Enter your Account ID: ");
            int x = Convert.ToInt32(Console.ReadLine());
            account_id = x;
            Console.Write("Enter Amount: ");
            double y = Convert.ToDouble(Console.ReadLine());
            amount = y;
            Console.Write("Enter Account Type: ");
            string z = Console.ReadLine();
            accType = z;
        }

        public void setAccountID(int a)
        {
            this.account_id = a;
        }
        public void setaccType(string a)
        {
            this.accType = a;
        }

        public int getAccID()
        { return account_id; }

        public string getAccType()
        { return accType; }
    }
}