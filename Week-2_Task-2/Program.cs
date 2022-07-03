using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Console.WriteLine("Enter Customer name: ");
            customer.customerName = Console.ReadLine();



            Console.WriteLine("Enter Customer Id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            customer.setId(id);



            Console.WriteLine("Customer Name: " + customer.customerName);
            Console.WriteLine("Customer ID: " + customer.getId());
        }
    }
}
