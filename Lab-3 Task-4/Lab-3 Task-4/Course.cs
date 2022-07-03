using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Task_4
{
    class Course
    {
        private string courseName;
        private string courseCode;
        private int courseCredit;
        // Properties for members
        // Property for courseName
        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }
        // Property for courseCode
        public string CourseCode
        {
            get { return courseCode; }
            set { courseCode = value; }
        }
        // Property for courseCredit
        public int CourseCredit
        {
            get { return courseCredit; }
            set { courseCredit = value; }
        }
        // method to display the members of the class
        public void ShowCourseInfo()
        {
            Console.WriteLine("Course Name: " + courseName);
            Console.WriteLine("Course Code: " + courseCode);
            Console.WriteLine("Course Credits: " + courseCredit);
        }
    }
}
