using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab_Task_2_3_
{
    class BankingAccount
    {
        private String name;
        private int balance;
        private String accountType;
        private int maxCredit;
        public BankingAccount(String name, String accountType, int initial_balance)
        {
            this.name = name;
            this.accountType = accountType;
            this.balance = initial_balance;
            maxCredit = 0;
            //set maxCredit to 500 by default for Overdraft 
            if (String.Equals(accountType, "Overdraft"))
            {
                maxCredit = 500;
            }
        }
        public bool deposit(int amount)
        {
            int temp = balance + amount;
            balance += amount;
            if (temp == balance)
                return true;
            return false;
        }
        public bool withdraw(int amount)
        {
            int maxWithdraw;
            if (String.Equals(accountType, "Overdraft"))
            {
                maxWithdraw = balance + maxCredit;
            }
            else if (String.Equals(accountType, "Savings"))
            {
                maxWithdraw = (int)0.8 * balance;
            }
            else
            {
                maxWithdraw = balance;
            }
            if (amount <= maxWithdraw)
            {
                balance -= amount;
                return true;
            }
            return false;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public String getName()
        {
            return name;
        }
        public String getAccountType()
        {
            return accountType;
        }
        public void setAccountType(String accountType)
        {
            if (!String.Equals(accountType, "Overdraft"))
            {
                maxCredit = 0;
            }
            this.accountType = accountType;
            if (String.Equals(accountType, "Overdraft"))
            {
                setMaxCredit(500);
            }
        }
        public void setMaxCredit(int maxCredit)
        {
            if (!String.Equals(accountType, "Overdraft"))
            {
                Console.WriteLine("Cannot set Max Credit for Account types other than Overdraft"); return;
            }
            this.maxCredit = maxCredit;
        }
        public int getMaxCredit()
        {
            return maxCredit;
        }
        public int getBalance()
        {
            return balance;
        }
        public override String ToString()
        {
            String returnString = "------------------------\nName: " + name + "\nAccount Type: " + accountType + "\nBalance: " + balance;
            if (String.Equals(accountType, "Overdraft"))
                returnString += "\nMaxCredit: " + maxCredit;
            /*returnString += "\n-----------------------\n";*/
            return returnString;
        }
    }

}
