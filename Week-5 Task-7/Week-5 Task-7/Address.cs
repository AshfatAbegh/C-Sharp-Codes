using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_Task_7
{
    class Address
    {
        private int houseNo;
        private int roadNo;
        public Address(int houseNo, int roadNo)
        {
            this.roadNo = roadNo;
            this.houseNo = houseNo;
        }



        public int HouseNo
        {
            get { return houseNo; }
            set { houseNo = value; }
        }
        public int RoadNo
        {
            get { return roadNo; }
            set { roadNo = value; }
        }



    }
}

