using machinetest1.Exceptions;
using machinetest1.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Reflection.Metadata.BlobBuilder;

namespace machinetest1.Interface
{
    public interface ILibraryRepository
    {
        void AddBook(Books book);
        void RemoveBook(string isbn);

        void BorrowBook(string isbn);
        void DisplayBooks();
    }
}
