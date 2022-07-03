using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Task_2
{
    class Triangle
    {
        // member variables
        private int x;
        private int y;
        private int z;
        // Properties for members
        // Property for x
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        // Property for y
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        // Property for z
        public int Z
        {
            get { return z; }
            set { z = value; }
        }
        // method to display the 3 sides of Triangle
        public void ShowInfo()
        {
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("z = " + z);
        }
        // method to display whether the triangle is equilateral, isosceles and scalene
        public void TestTriangle()
        {
            if (x == y && y == z)
                Console.WriteLine("Triangle is equilateral");
            else if (x == y || x == z || y == z)
                Console.WriteLine("Triangle is isosceles");
            else
                Console.WriteLine("Triangle is scalene");
        }
    }
}
