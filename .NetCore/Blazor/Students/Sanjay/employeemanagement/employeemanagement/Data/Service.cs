namespace employeemanagement.Data
{
    public class Service
    {
        private static List<Entry> Booklist = new();

        public Task<bool> AddEntry(Entry newEntry)
        {
            Booklist.Add(new Entry
            {
                Name = newEntry.Name,
                Amount = newEntry.Amount,
                Description = newEntry.Description
            });
            return Task.FromResult(true);
        }
        public Task<List<Entry>> GetAllEntries()
        {
            return Task.FromResult(Booklist);
        }
    }
}
