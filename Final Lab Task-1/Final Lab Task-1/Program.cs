/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab_Task_1
{
    //multi-level inheritance
    class Car
    {
        protected string model;
        protected string color;
        protected int price;

        protected void PrintCarInformation()
        {
            Console.WriteLine("Model:" + model);
            Console.WriteLine("Color:" + color);
            Console.WriteLine("Price:" + price);
        }

        class Ferrari : Car
        {
            public int speed;

            public void PrintSpeed()
            {
                Console.WriteLine("Speed:" + speed);
            }
        }
        class Maruti : Ferrari
        {
            public float mileage;

            public void PrintMileage()
            {
                Console.WriteLine("Mileage:" + mileage);
            }
        }
        public static void Main(string[] args)
        {
            Maruti myCar = new Maruti();
            myCar.model = "Alto";
            myCar.color = "White";
            myCar.price = 52020;
            myCar.mileage = 30.5f;
            myCar.speed = 100;
            myCar.PrintCarInformation();
            myCar.PrintSpeed();
            myCar.PrintMileage();
            Console.ReadLine();
        }
    }
}*/

//hierarchical inheritance
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab_Task_1
{
    class Car
    {
        protected string model;
        protected string color;
        protected int price;

        protected void PrintCarInformation()
        {
            Console.WriteLine("Model:" + model);
            Console.WriteLine("Color:" + color);
            Console.WriteLine("Price:" + price);
        }

        class Ferrari : Car
        {
            public int speed;

            public void PrintSpeed()
            {
                Console.WriteLine("Speed:" + speed);
            }
        }
        class Maruti : Car
        {
            public float mileage;

            public void PrintMileage()
            {
                Console.WriteLine("Mileage:" + mileage);
            }
        }
        public static void Main(string[] args)
        {
            Maruti myCar = new Maruti();
            myCar.model = "Alto";
            myCar.color = "White";
            myCar.price = 52020;
            myCar.mileage = 30.5f;
            myCar.PrintCarInformation();
            myCar.PrintMileage();
            Console.ReadLine();
        }
    }
}