using Machinetest.Exceptions;
using Machinetest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machinetest.Interface
{
    public interface ILibraryRepository
    {
        void AddBook(Book book);
        void RemoveBook(string isbn);

        void BorrowBook(string isbn);
        void DisplayBooks();
    }
}
