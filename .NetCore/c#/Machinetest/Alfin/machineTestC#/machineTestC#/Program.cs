namespace machineTestC_
{
    internal class Program
    {
        struct Book
        {
            public int BookID;
            public string Title;
            public string Author;
        }
        static void Main(string[] args)
        {
            Book[] books = new Book[5];
            Console.WriteLine("enter details of books:\n");
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"Book{i + 1}:");
                Console.Write("Enter Book ID:");
                books[i].BookID = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Title:");
                books[i].Title = Console.ReadLine();
                Console.Write("Enter Author:");
                books[i].Author = Console.ReadLine();
                Console.WriteLine();
            }

            
            Console.Write("Enter Book ID to search: ");
            int searchID = Convert.ToInt32(Console.ReadLine());

            bool found = false;

            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].BookID == searchID)
                {
                    Console.WriteLine("Book Found:");
                    Console.WriteLine("Book ID: " + books[i].BookID);
                    Console.WriteLine("Title: " + books[i].Title);
                    Console.WriteLine("Author: " + books[i].Author);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Book not found.");
            }

            Console.ReadLine();
        }

        
    }
}
