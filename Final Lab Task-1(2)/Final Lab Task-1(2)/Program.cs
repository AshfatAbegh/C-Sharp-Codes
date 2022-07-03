/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab_Task_1_2_
{
    //method overloading
    class Program
    {
        void car(int speed, float mileage)
        {
            Console.WriteLine("Speed:"+speed,"Mileage:"+mileage);
        }
        void car(float mileage, int speed)
        {
            Console.WriteLine("Mileage:"+mileage, "Speed:"+speed);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.car(100,50.5f);
            obj.car(50.5f,100);
            Console.ReadLine();
        }
    }
}*/

//method overriding
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab_Task_1_2_
{
    class Ferrari
    {
        public void Move()
        {
            Console.WriteLine("Ferrari is Moving");
        }
    }
    class Maruti:Ferrari
    {
        public void Move()
        {
            Console.WriteLine("Maruti is Moving");
        }
        public static void Main(string[] args)
        {
            Maruti myCar = new Maruti();
            myCar.Move();
            Console.ReadLine();
        }
    }
}*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab_Task_1_2_
{
    //constructor
    class Car
    {
        string carModel;
        int carYear;

        public Car(string model, int year)
        {
            carModel = model;
            carYear = year;
        }
        static void Main(string[] args)
        { 
            Car myCar = new Car("Ferrari",1959);
            Console.WriteLine("Model:"+myCar.carModel);
            Console.WriteLine("Year:"+myCar.carYear);
            Console.ReadLine();
        }

    }
}
