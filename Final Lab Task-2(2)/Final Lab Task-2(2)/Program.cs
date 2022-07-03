using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab_Task_2_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicCalculator bcal = new BasicCalculator();
            ScientificCalculator scal = new ScientificCalculator();
            Console.WriteLine("***********Basic Calculator*************"); Console.WriteLine();
            Console.WriteLine("Addition Operation:");
            bcal.sum(25, 5);
            bcal.displayResult();
            Console.WriteLine();
            Console.WriteLine("Subtraction Operation:");
            bcal.sub(25, 5);
            bcal.displayResult();
            Console.WriteLine();
            Console.WriteLine("Multiplication Operation:");
            bcal.multiplication(25, 5);
            bcal.displayResult();
            Console.WriteLine();
            Console.WriteLine("Division Operation:");
            bcal.division(25, 5);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("***********Scientific Calculator*************"); Console.WriteLine();
            Console.WriteLine("X to Y Operation:");
            Console.WriteLine();
            scal.XtoY(100, 500);
            Console.WriteLine("Square Operation:");
            scal.square(4);
            scal.displayResult();
            Console.WriteLine();
            Console.WriteLine("Factorial Operation:"); scal.factorial(5);
        }
    }
} 


