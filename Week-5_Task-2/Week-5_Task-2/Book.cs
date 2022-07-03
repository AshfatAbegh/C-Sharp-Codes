using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_Task_2
{
    class Book
    {
        public String bookName;
        private String bookAuthor;
        private String bookId;
        private String bookType;
        private int bookCopy;

        public Book()
        { }
        public Book(String bn, String ba, String bi, String bt, int bc)
        {
            bookName = bn;
            bookAuthor = ba;
            bookId = bi;
            bookType = bt;
            bookCopy = bc;
        }
        public void setBook(String bn, String ba, String bi, String bt, int bc)
        {
            bookName = bn;
            bookAuthor = ba;
            bookId = bi;
            bookType = bt;
            bookCopy = bc;
        }
        public string getBookName(String bookName)
        {
            return bookName;
        }
        public string getBookAuthor(String bookAuthor)
        {
            return bookAuthor;
        }
        public string getBookId(String bookId)
        {
            return bookId;
        }
        public string getBookType(String bookType)
        {
            return bookType;
        }
        public int getBookCopy(int bookCopy)
        {
            return bookCopy;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Book Name : " + bookName);
            Console.WriteLine("Book Author : " + bookAuthor);
            Console.WriteLine("Book Id : " + bookId);
            Console.WriteLine("Book Type : " + bookType);
            Console.WriteLine("Book Copy : " + bookCopy);
        }
        public void AddBookCopy(int x)
        {
            bookCopy += x;
        }
    }
}

