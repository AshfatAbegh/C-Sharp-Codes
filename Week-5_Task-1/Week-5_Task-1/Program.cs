using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account sender = new Account("Abir","2-21",20000);
            Account reciever = new Account("Araf","5-1",30000);

            sender.transfer(1000, reciever);

            Console.WriteLine("Balance of Sender: " +sender.Balance);
            Console.WriteLine("Balance of Receiver: " + reciever.Balance);

            Console.ReadLine();

        }
    }
}
