using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_Task_7
{
    class Person
    {
        Address address;
        Address[] addresses = new Address[2];



        public Person() { }
        public Person(Address address)
        {
            this.address = address;
        }
        public Person(Address address1, Address address2)
        {
            this.addresses[0] = address1;
            this.addresses[1] = address2;
        }
        public void showAddress()
        {
            Console.WriteLine("Address No: " + address.HouseNo);
            Console.WriteLine("Road No: " + address.RoadNo);
        }
    }
}

