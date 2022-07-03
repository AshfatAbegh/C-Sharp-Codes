using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Lab_L
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine("Enter name: ");
            person.personName = Console.ReadLine();



            Console.WriteLine("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            person.setAge(age);



            Console.WriteLine("Name: " + person.personName);
            Console.WriteLine("Age: " + person.getAge());

            Console.ReadLine();
        }
    }
}
