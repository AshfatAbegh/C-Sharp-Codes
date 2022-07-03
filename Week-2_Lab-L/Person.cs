using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Lab_L
{
   
    
        public class Person // pascal notation = PascalNotation , we will use it for class name
        {
            //state- field
            public string personName; // camelNotation - we will use this convention for variables
            private int personAge;



            //behaviour - Method
            // Method signature



            /* access_modifier reurn-type method_name( parameter 1 , parameter 2)
             * {
             *      method body or scope
             * }*/
            public void setAge(int p)
            {
                personAge = p;
            }
            public int getAge()
            {
                return personAge;
            }





        }
    }






