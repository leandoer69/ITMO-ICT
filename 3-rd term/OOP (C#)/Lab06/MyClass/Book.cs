using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    internal class Book
    {
        private String author;
        private String title; 
        private String publisher; 
        private int pages; 
        private int year;
        private static double price = 9;


        public static void SetPrice(double price)
        {
            Book.price = price;
        }

        public void Show()
        {
            Console.WriteLine("\nКнига:\n Автор: {0}\n Название: {1} \n Год издания: {2}\n " +
                "{3} стр. \n Стоимость аренды: {4} р.", author, title, year, pages, Book.price);
        }

        public double PriceBook(int s)
        {
            double cust = s * price;
            return cust;
        }

        public Book()
        {

        }

        static Book()
        {
            price = 10;
        }

        public Book(String author, String title, String publisher, int pages, int year)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
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

    }

}
