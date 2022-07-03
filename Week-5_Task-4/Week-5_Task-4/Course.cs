using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_Task_4
{
    class Course
    {
        private String courseName;
        private String courseCode;
        private int courseCredit;
        public Course()
        { }
        public Course(String n, String co, int cr)
        {
            courseName = n;
            courseCode = co;
            courseCredit = cr;
        }
        public void setCourse(String n, String co, int cr)
        {
            courseName = n;
            courseCode = co;
            courseCredit = cr;
        }
        public string getCourseName(String courseName)
        {
            return courseName;
        }
        public string getCourseCode(String courseCode)
        {
            return courseCode;
        }
        public int getCourseCredit(int courseCredit)
        {
            return courseCredit;
        }
        public void ShowCourseInfo()
        {
            Console.WriteLine("Course Name : " + courseName);
            Console.WriteLine("Course Code : " + courseCode);
            Console.WriteLine("Course Credit : " + courseCredit);
        }
    }
}
