using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Abir";
            student.ID = "22256263";
            student.Department = "CSE";
            student.CGPA = 3;

            student.ShowInfo();

            
            Console.ReadLine();
               
              

        }
    }
}
