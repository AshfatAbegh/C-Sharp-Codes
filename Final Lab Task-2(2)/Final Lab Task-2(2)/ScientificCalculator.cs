using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab_Task_2_2_
{
    class ScientificCalculator : ScientificCalculatorInterface
    {
        int result;
        public int square(int number)
        {
            Console.WriteLine("Number : " + number);
            result = number * number;
            return result;
        }
        public void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public int XtoY(int a, int b)
        {
            Console.WriteLine("Value of X and Y before swapping"); Console.WriteLine("X=" + " " + a);
            Console.WriteLine("Y=" + " " + b);
            Swap(ref a, ref b);
            Console.WriteLine();
            Console.WriteLine("Value of X and Y after swapping"); Console.WriteLine("X=" + " " + a);
            Console.WriteLine("Y=" + " " + b);
            Console.ReadLine();
            return 0;
        }
        public int factorial(int number)
        {
            Console.WriteLine("Number : " + number);
            int fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact *= i;
            }
            int ans = fact;
            Console.WriteLine("Result : " + ans);
            return 0;
        }
        public void displayResult()
        {
            Console.WriteLine("Result : " + result);
        }
    }

}
