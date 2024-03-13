using Homework_Delegates.Data;
using Homework_Delegates.Models;
using Homework_Delegates.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Delegates.Service
{
    internal class BookService : IBookService
    {
        public int NumberOfBooks(Predicate<Book> predicate)
        {
            int count = 0;

            foreach(var book in BookDbContext.books)
            {
                if(predicate(book))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
