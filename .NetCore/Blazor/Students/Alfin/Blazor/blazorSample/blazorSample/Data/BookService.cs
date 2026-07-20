using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

namespace blazorSample.Data
{
    public class BookService
    {
        private static List<Entry> Booklist = new();

        public Task<bool>AddEntry(Entry newEntry)

        {
            Booklist.Add(new Entry
            {
                Name = newEntry.Name,
                      Description = newEntry.Description,
                amount = newEntry.amount
               
            });

            return Task.FromResult(true);
        }
        public Task<List<Entry>> GetAllEntries()
        {
            return Task.FromResult(Booklist);

        }


       
            
    }
}
