
using machinetest1.Exceptions;
using machinetest1.Interface;
using machinetest1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace machinetest1.Repository
{
    public class LibraryRepository : ILibraryRepository
    {
        List<Books> books = new List<Books>();


        public void AddBook(Books book)
        {
            books.Add(book);

            Console.WriteLine( "Book added successfully");
        }


        public void RemoveBook(string isbn)
        {
            Books foundBook =books.Find(b => b.ISBN == isbn);

            if (foundBook == null)
            {
               throw new  BookNotFoundException(  "Book not found");
            }

            books.Remove(foundBook);

            Console.WriteLine( "Book Removed Successfully");
        }


        public void BorrowBook(string isbn)
        {
            Books foundBook = books.Find(  b => b.ISBN == isbn);

            if (foundBook == null)                                     
            {
                throw new BookNotFoundException( "Book not found");
            }

            if (foundBook.QuantityAvailable <= 1)
            {
                throw new OutOfStockException("Book Out Of Stock");
            }

            foundBook.QuantityAvailable--;

            Console.WriteLine("Book Borrowed Successfully");
        }


        public void DisplayBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No Books Available");

                return;
            }

            Console.WriteLine("\nAvailable Books");

            foreach (Books book in books)
            {
                Console.WriteLine("Title : " + book.Title + " | Author : " + book.Author + " | ISBN : " + book.ISBN + " | Quantity : " + book.QuantityAvailable);
            }
        }
    }
}
