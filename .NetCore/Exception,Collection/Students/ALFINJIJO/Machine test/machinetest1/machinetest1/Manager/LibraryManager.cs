using machinetest1.Exceptions;
using machinetest1.Interface;
using machinetest1.Models;
using machinetest1.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace machinetest1.Manager
{
    public class Librarymanager
    {
        ILibraryRepository libraryrepo = new LibraryRepository();

        public void start()
        {
            int choice = 0;

            while (choice != 5)
            {
                Console.WriteLine();
                Console.WriteLine(
                    "------- LIBRARY MANAGEMENT SYSTEM -------");

                Console.WriteLine("1. Add Book");


                Console.WriteLine("2. Remove Book");


                Console.WriteLine("3. Borrow Book");


                Console.WriteLine("4. Display Books");



                Console.WriteLine("5. Exit");


                Console.Write("Enter Choice : ");


                choice = Convert.ToInt32( Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        Console.Write("Enter Title : ");


                        string title = Console.ReadLine();


                        Console.Write("Enter Author : ");


                        string author = Console.ReadLine();


                        Console.Write("Enter ISBN : ");


                        string isbn = Console.ReadLine();


                        Console.Write("Enter Quantity : ");


                        int quantity = Convert.ToInt32( Console.ReadLine());


                        Books book = new Books(title, author, isbn, quantity);


                        libraryrepo.AddBook(book);


                        break;

                    case 2:

                        try
                        {
                            Console.Write("Enter ISBN : ");


                            string removeISBN = Console.ReadLine();



                            libraryrepo.RemoveBook( removeISBN);

                        }
                        catch
                            (BookNotFoundException ex)
                        {
                            Console.WriteLine(ex.Message);

                        }

                        break;

                    case 3:
                        try
                        {

                            Console.Write("Enter ISBN : ");


                            string borrowISBN = Console.ReadLine();

                            libraryrepo.BorrowBook(borrowISBN);
                        }
                            catch (BookNotFoundException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                             catch (OutOfStockException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;


                        break;

                    case 4: libraryrepo.DisplayBooks();


                        break;

                    case 5:

                        Console.WriteLine(  "Exiting...");

                        break;

                    default:

                        Console.WriteLine("Invalid Choice");


                        break;
                }
            }
        }
    }
}

