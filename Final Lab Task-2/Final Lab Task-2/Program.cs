using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab_Task_2
{
    abstract class person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public abstract void work();
    }
    class Student : person
    {
        public override void work()
        {
            Console.WriteLine("Studying");
        }
    }
    class Employee : person
    {
        public double salary { get; set; }
        public string Designation { get; set; }
        public override void work()
        {
            Console.WriteLine("Earning");
        }
    }

    class Manager : Employee
    {
        public override void work()
        {
            Console.WriteLine("Manages Team");
        }
    }

    class BranchManager: Manager
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            person p1 = new Student();
            p1.work();
            p1 = new Employee();
            p1.work();
            p1 = new BranchManager();
            p1.work();
            Console.ReadLine();
        }
    }
}
