using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Task_1
{
    class Student
    {
        // member 􀅜elds
        private string name;
        private string id;
        private string department;
        private float cgpa;
        // properties for fields
        // Property for name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        // Property for id
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        // Property for department
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        // Property for cgpa
        public float CGPA
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        // method to display the 􀅜elds
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Department: " + department);
            Console.WriteLine("CGPA: " + cgpa);
        }
    }
}
