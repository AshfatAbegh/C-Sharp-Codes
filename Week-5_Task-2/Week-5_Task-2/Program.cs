using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
  
            
            b.setBook("Math","Abraham","521321","Learn",5);
         
            b.getBookName("Math");
            b.getBookAuthor("Abraham");
            b.getBookId("521321");
            b.getBookType("Learning");
            b.getBookCopy(5);

            b.AddBookCopy(10);

            b.ShowInfo();
            Console.ReadLine();
           
        }
    }
}
