using System;
using System.Collections.Generic;
using System.Text;

namespace machinetest1.Models
{
    public class Books
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        public int QuantityAvailable { get; set; }

        public Books(string title, string author, string iSBN, int quantityAvailable)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            QuantityAvailable = quantityAvailable;
        }
    }
}
