using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab_Task_2_3_
{
    public class TestBankingApplication
    {
        public static void Main()
        {
            BankingAccount acc1 = new BankingAccount("Adam", "Current", 50000); BankingAccount acc2 = new BankingAccount("Alex", "Savings", 20000); BankingAccount acc3 = new BankingAccount("Abraham", "Fixed", 1200);
            Console.WriteLine("3 Accounts Created");
            Console.WriteLine(acc1);
            Console.WriteLine(acc2);
            Console.WriteLine(acc3);
            if (acc1.deposit(20000))
            {
                Console.WriteLine("Deposit Successful");
                Console.WriteLine(acc1);
            };
            if (!acc2.withdraw(50000))
            {
                Console.WriteLine("Unable to withdraw full amount");
                Console.WriteLine(acc2);
            }
            if (acc3.withdraw(25000))
            {
                Console.WriteLine("Succesful withdraw"); Console.WriteLine(acc3);
            }
            //Changing the account type 
            acc2.setAccountType("Fixed");
            acc1.setAccountType("Savings");
            Console.WriteLine("Accounts After Modification");
            Console.WriteLine(acc1);
            Console.WriteLine(acc2);
            Console.WriteLine(acc3);
        }
    }

}
