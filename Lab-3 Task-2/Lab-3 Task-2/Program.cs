using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            triangle.X = 25;
            triangle.Y = 25;
            triangle.Z = 50;

            triangle.ShowInfo();
            triangle.TestTriangle();

            Console.ReadLine();
        }
    }
}
