using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Lab
{
    class Sample
    {
        public void Test(ref int number)
        {
            number++;
            Console.WriteLine("Printing from the Test method: " + number);
        }
        public void Test1(out int number)
        {
            number = 10;
            Console.WriteLine("Printing from the Test1 method: " + number);
        }
        public void Test3(params int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "   ");
            }
            Console.WriteLine("");
            
            Console.ReadLine();
        }
       
    }
}
