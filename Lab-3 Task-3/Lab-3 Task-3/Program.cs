using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a= new Account();
            a.Name = "Abir";
            a.ID = "663236";
            a.Balance = 10000;
            Console.WriteLine("Account Name : "+ a.Name);
            Console.WriteLine("Account Id : "+ a.ID);
            Console.WriteLine("Account Balance : "+ a.Balance);
            Console.Write("Enter Amount to Deposit:");
            int dep = Convert.ToInt16(Console.ReadLine());
            a.Deposit(dep);
            Console.WriteLine("Balance:" + a.Balance);
            Console.Write("Enter Amount to Withdraw:");
            int wd = Convert.ToInt16(Console.ReadLine());
            a.Withdraw(wd);
            Console.WriteLine("Balance:" + a.Balance);


           
         
           Console.ReadLine();
        }
    }
}
