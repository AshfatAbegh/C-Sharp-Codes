using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weel_1_Lab___L
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Id:19-40195-1");
            Console.WriteLine("Name:Ashfat Al Rashid");
            Console.WriteLine("Dep:Computer Science");

            int i;
            Console.Write("Enter a Number : ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("Entered Number is an Even Number");
                Console.Read();
              
            }
            else
            {
                Console.Write("Entered Number is an Odd Number");
                Console.Read();
                
            }
        }
    }
}
