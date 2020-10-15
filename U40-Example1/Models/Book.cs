using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U40_Example1.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string CoverImage { get; set; }
    }

    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var Books = new List<Book>();
            Books.Add(new Book { BookId = 1, Title = "Vulpate", Author = "Futurum", CoverImage = "Assets/1.jpg" });
            Books.Add(new Book { BookId = 2, Title = "Dog", Author = "DogFather", CoverImage = "Assets/2.jpg" });
            Books.Add(new Book { BookId = 3, Title = "Cat", Author = "Catother", CoverImage = "Assets/3.jpg" });
            Books.Add(new Book { BookId = 4, Title = "Doctor", Author = "Denest", CoverImage = "Assets/4.jpg" });
            Books.Add(new Book { BookId = 5, Title = "Star", Author = "Dark", CoverImage = "Assets/5.jpg" });
            Books.Add(new Book { BookId = 6, Title = "Sun", Author = "Skynet", CoverImage = "Assets/6.jpg" });
            Books.Add(new Book { BookId = 7, Title = "Fish", Author = "Beach", CoverImage = "Assets/7.jpeg" });
            Books.Add(new Book { BookId = 8, Title = "Batman", Author = "People", CoverImage = "Assets/8.jpg" });
            return Books;
        }
    }
}
