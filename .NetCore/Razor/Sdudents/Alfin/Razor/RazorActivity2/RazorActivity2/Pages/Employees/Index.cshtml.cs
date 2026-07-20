using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorActivity2.Models;

namespace RazorActivity2.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }
        
        public IList<Employee> EmployeeList { get; set; } = new List<Employee>();
        

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; } 

        public async Task OnGetAsync()
        {
            var query = _context.Employees.AsQueryable();

            if (!string.IsNullOrWhiteSpace(SearchTerm))
            {
                query = query.Where(e =>
                    e.Name.Contains(SearchTerm) ||
                    e.Position.Contains(SearchTerm));
            }

            EmployeeList = await query.ToListAsync();
        }
    }
}
