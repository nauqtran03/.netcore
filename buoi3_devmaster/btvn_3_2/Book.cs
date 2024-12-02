using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btvn_3_2
{
    internal class Book
    {
        private string author;
        private int pages;
        private string isbn;
        private string title;
        private int currentpage;

        public Book()
        {
            this.currentpage = 1;
        }
        public Book(string author, int pages, string isbn, string title, int currentpage)
        {
            this.author = author;
            this.pages = pages;
            this.isbn = isbn;
            this.title = title;
            this.currentpage = currentpage;
        }
        public string Author
        {
            get { return this.author; }
            set { this.author = value; }
        }
        public int Pages
        {
            get { return this.pages; }
            set { this.pages = value; }
        }
        public string Isbn
        {
            get { return this.isbn; }
            set { this.isbn = value; }
        }
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public int CurrentPage
        {
            get { return this.currentpage; }
            set {
                if (value > 0 && value <= this.pages)
                    this.currentpage = value;
            }
        }

        public void flipPageForward()
        {
            if (this.currentpage <this.pages)
            {
                this.currentpage++;
                Console.WriteLine($"Current page: {this.currentpage}");
            }
            else
            {
                Console.WriteLine("You are on the last page");
            }
        }
        public void flipPageBackward() 
        {
            if(this.currentpage > 1)
            {
                this.currentpage--;
                Console.WriteLine($"Current page: {this.currentpage}");
            }
            else
            {
                Console.WriteLine("You are on the first page");
            }
        }
        public void Display()
        {
            Console.WriteLine("Book information: ");
            Console.WriteLine("Author: "+author);
            Console.WriteLine("Pages: "+pages);
            Console.WriteLine("ISBN: "+isbn);
            Console.WriteLine("Title: "+title);
            Console.WriteLine("Current Page: "+currentpage);
        }
    }
}
