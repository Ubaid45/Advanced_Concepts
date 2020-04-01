using System;
using System.Collections.Generic;

namespace Advanced_Concepts.LamdaExpressions
{
    public class BookRepository
    {
        public BookRepository()
        {
        }

        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book(){Title = "Design Patterns", Price = 5},
                new Book(){Title = "Fundamentals of c#", Price = 50},
                new Book(){Title = "Java Basics", Price = 53},
                new Book(){Title = "Introduction to JS", Price = 35},
                new Book(){Title = "Mastering React JS", Price = 25}
            };
        }
    }
}
