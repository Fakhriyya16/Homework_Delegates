using Homework_Delegates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Delegates.Service.Interfaces
{
    internal interface IBookService
    {
        public int NumberOfBooks(Predicate<Book> predicate);
    }
}
