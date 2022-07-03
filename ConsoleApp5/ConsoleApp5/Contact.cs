using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Contact
    {
        private string personName;
        private string personId;
        private int personAge;
        private string mobileNumber;
        private enum gender;

        public Contact()
        {

        }
        public Contact(string n, string id, int age, string nmbr, char g)
        {
            personName = n;
            personId = id;
            personAge = age;
            mobileNumber = nmbr;
            gender = g;

        }
        public void setPerson(string n, string id, int age, string nmbr, enum g)
        {
            personName = n;
            personId = id;
            personAge = age;
            mobileNumber = nmbr;
            gender = g;
        }
    public string getPersonName(string personName)
    {
        return personName;
    }
    public string getPersonId(string personId)
    {
        return personId;
    }
    public int getPersonAge(int personAge)
    {
        return personAge;
    }
    public string getMobileNumber(string mobileNumber)
    {
        return mobileNumber;
    }
    public char getGender(enum gender)
        {
            return gender;
        }
public void ShowPersonInfo()
{
    Console.WriteLine("Person Name:" + personName);
    Console.WriteLine("Person Id:" + personId);
    Console.WriteLine("Person Age:" + personAge);
    Console.WriteLine("Person Number:" + mobileNumber);
    Console.WriteLine("Person Gender:" + gender);
}
   }
}
