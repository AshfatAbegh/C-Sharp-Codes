using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address(10, 15);
            Address address1 = new Address(101, 151);
            Person person = new Person(address);
            person.showAddress();



            Person person1 = new Person(address, address1);
            Console.ReadLine();
        }
    }
}
    

