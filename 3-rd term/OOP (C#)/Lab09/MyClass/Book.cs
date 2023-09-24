using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    internal class Book : Item
    {
        private String author;
        private String title; 
        private String publisher; 
        private int pages; 
        private int year;
        private static double price = 9;

        public delegate void ProcessBookDelegate(Book book);
        public static event ProcessBookDelegate RetSrok;
        private bool returnSrok = false;
        public bool ReturnSrok
        {
            get
            {
                return returnSrok;
            }
            set
            {
                returnSrok = value;
                if (ReturnSrok == true)
                    RetSrok(this);
            }
        }

        public Book(String author, String title, String publisher, int pages, int year,
            long invNumber, bool taken) : base(invNumber, taken)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }
        public Book()
        {

        }

        static Book()
        {
            price = 10;
        }

        public Book(String author, String title)
        {
            this.author = author;
            this.title = title;
        }

        public void SetBook(String author, String title, String publisher, int pages, int year)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }

        public static void SetPrice(double price)
        {
            Book.price = price;
        }

        public override void Show()
        {
            Console.WriteLine("\nКнига:\n Автор: {0}\n Название: {1} \n Год издания: {2}\n " +
                "{3} стр. \n Стоимость аренды: {4} р.", author, title, year, pages, Book.price);
            base.Show();
        }

        public double PriceBook(int s)
        {
            double cust = s * price;
            return cust;
        }

        public override void Return() 
        {
            if (ReturnSrok == true)
                taken = true;
            else
                taken = false;
        }

        public void ProcessPaperbackBooks(ProcessBookDelegate processBook)
        {
            if (ReturnSrok)
            {
                processBook(this);
            }    
        }

        public override string ToString()
        {
            string str = this.title + ", " + this.author + " Инв.номер " + this.invNumber;
            return str;
        }


    }

}
