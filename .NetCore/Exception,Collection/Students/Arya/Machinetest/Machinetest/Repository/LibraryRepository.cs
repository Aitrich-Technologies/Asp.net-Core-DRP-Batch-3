
using Machinetest.Exceptions;
using Machinetest.Interface;
using Machinetest.Model;
using System;
using System.Collections.Generic;

namespace Machinetest.Repository
{
    public class LibraryRepository : ILibraryRepository
    {
        List<Book> books = new List<Book>();

        
        public void AddBook(Book book)
        {
            books.Add(book);

            Console.WriteLine("Book added successfully");
            
        }

        
        public void RemoveBook(string isbn)
        {
            Book foundBook = books.Find(b => b.ISBN == isbn);
            

            if (foundBook == null)
            {
                throw new
                    BookNotFoundException("Book not found");
                
            }

            books.Remove(foundBook);

            Console.WriteLine("Book Removed Successfully");
            
        }

        
        public void BorrowBook(string isbn)
        {
            Book foundBook = books.Find(
                
                b => b.ISBN == isbn);

            if (foundBook == null)
            {
                throw new
                    BookNotFoundException("Book not found");
                
            }

            if (foundBook.QuantityAvailable <= 0)
           
            {
                throw new
                    OutofStockException("Book Out Of Stock");
            
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

            Console.WriteLine("Available Books");
            

            foreach (Book book in books)
            {
                Console.WriteLine("Title : " + book.Title
                    + " | Author : "
                    + book.Author
                    + " | ISBN : "
                    + book.ISBN
                    + " | Quantity : "
                    + book.QuantityAvailable);


            }
        }
    }
}