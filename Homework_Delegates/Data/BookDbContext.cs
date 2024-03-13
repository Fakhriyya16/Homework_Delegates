using Homework_Delegates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Delegates.Data
{
    internal class BookDbContext
    {
        public static List<Book> books;
        static BookDbContext()
        {
            books = new List<Book>()
            {
                new Book()
                {
                    Id = 1,
                    Name = "The Book Thief",
                    Author = "Markus Zusak"
                },
                new Book()
                {
                    Id = 2,
                    Name = "The Alchemist",
                    Author = "Paulo Coelho"
                },
                new Book()
                {
                    Id = 3,
                    Name = "Leyla ve Mecnun",
                    Author = "Nizami Gencevi"
                },
                new Book()
                {
                    Id = 4,
                    Name = "Iskendername",
                    Author = "Nizami Gencevi"
                }
            };
        }
    }
}
