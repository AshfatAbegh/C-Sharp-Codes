using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Task_3
{
   class Account
    {
        // member variables
        private string accName;
        private string acid;
        private int balance;
        // Properties for members
        // Property for accName
        public string Name
        {
            get { return accName; }
            set { accName = value; }
        }
        // Property for acid
        public string ID
        {
            get { return acid; }
            set { acid = value; }
        }
        // Property for balance
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        // method to add amount to the balance
        public void Deposit(int amount)
        {
            balance += amount;
        }
        // method to subtract amount from balance
        public void Withdraw(int amount)
        {
            if (amount <= balance) // check that amount to withdraw is less than or equal to balance
                balance -= amount;
        }
     
    }
}
