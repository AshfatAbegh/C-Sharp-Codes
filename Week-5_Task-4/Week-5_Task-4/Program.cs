using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Course c = new Course();

            c.setCourse("OOP2","231361",4);

            c.getCourseName("OOP2");
            c.getCourseCode("231361");
            c.getCourseCredit(4);

            c.ShowCourseInfo();
            Console.ReadLine();
        }
    }
}
