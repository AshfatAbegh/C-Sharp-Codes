using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course();
            course.CourseName = "OOP2";
            course.CourseCode = "654625";
            course.CourseCredit = 4;

            course.ShowCourseInfo();
            Console.ReadLine();
        }
    }
}
