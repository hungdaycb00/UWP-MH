using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u41_BookApp.Models
{
   public class Book
    {
        public string name { get; set; }
        public float price { get; set; }
        public int quantity { get; set; }
        public string coverPath { get; set; }
    }

    public class ManagerBook
    {
        public static List<Book> GetBooks()
        {
            var Books = new List<Book>();

            Books.Add(new Book { name = "Dog", price = 99.9f, quantity = 10, coverPath = "Assets/dog.jpg" });
            Books.Add(new Book { name = "Cat", price = 99.9f, quantity = 10, coverPath = "Assets/cat.jpg" });
            Books.Add(new Book { name = "Fish", price = 99.9f, quantity = 10, coverPath = "Assets/fish.jpg" });
            Books.Add(new Book { name = "Tiger", price = 99.9f, quantity = 10, coverPath = "Assets/tiger.jpg" });
            Books.Add(new Book { name = "Crocodile", price = 99.9f, quantity = 10, coverPath = "Assets/crocodile.jpg" });
            Books.Add(new Book { name = "Duck", price = 99.9f, quantity = 10, coverPath = "Assets/duck.jpg" });
            return Books;
        }
        
    }
}
