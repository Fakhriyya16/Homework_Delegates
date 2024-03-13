using Homework_Delegates.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Delegates.Controllers
{
    internal class BookController
    {
        BookService bookService;
        public BookController()
        {
            bookService = new BookService();
        }
        public void NumberOfBooks()
        {
            var response = bookService.NumberOfBooks(m => m.Author == "Nizami Gencevi");
            Console.WriteLine(response);
        }
    }
}
