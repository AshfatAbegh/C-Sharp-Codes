using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1_Lab_L
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Your name is:" + name);

            Console.Write("Enter Your Address:");
            string address = Console.ReadLine();
            Console.WriteLine("Address is:"+address);


            Console.Write("Tell Your Dept:");
            string dept = Console.ReadLine();
            Console.WriteLine("Dept is:"+dept);

            Console.Write("Place You Travel:");
            string travel = Console.ReadLine();
            Console.WriteLine("Travel:"+travel);

            Console.ReadLine();

        }
    }
}
