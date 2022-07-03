using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Task_2
{
    public class Customer
    {
        public string customerName;
        private int customerId;

        public void setId(int id)
        {
            customerId = id;
        }
        public int getId()
        {
            return customerId;
        }
    }
}
