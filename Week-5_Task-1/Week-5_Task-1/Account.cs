using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_Task_1
{
    class Account
    {
        private string accName;
        private string accId;
        private int balance;

        public Account(string accName, string accId, int balance)
        {
            this.accName = accName;
            this.accId = accId;
            this.balance = balance;
        }

        public void transfer(int amount, Account reciever)
        {
            if(amount>0 && amount < this.balance)
            {
                this.balance = this.balance - amount;
                reciever.balance = reciever.balance + amount;
            }
        }
        public int Balance
        { get { return balance; } }
    }
}
