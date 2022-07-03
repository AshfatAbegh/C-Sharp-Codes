using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample s = new Sample();
            int value = 100;
            s.Test(ref value);
            Console.WriteLine("Printing from the main method: " + value);




            s.Test1(out value);
            Console.WriteLine("Printing from the main method: " + value);



            s.Test3(50);
            s.Test3(15);
            s.Test3(18, 20);
            s.Test3(48, 88, 100, 67);

            Console.ReadLine();

        }
    }
}
