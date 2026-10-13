using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {

        //private fields
             private string title;
             private string author;
             private string isbn;


        //public properties
        public string Title
                    {
                        get { return title; }  // get method
                        set { title = value; } // set method
                    }


        public string Author
            {
              get { return author; }  // get method
              set { author = value; } // set method
            }


        public string ISBN
            {
                get { return isbn; }  // get method
                set { isbn = value; } // set method
            }




        public Book(string bookTitle,string bookAuthor,string bookISBN)
        {
           Title=bookTitle;
           Author=bookAuthor;
           ISBN = bookISBN;
        }
          

        



      

        //Constructor


        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
} 
    
