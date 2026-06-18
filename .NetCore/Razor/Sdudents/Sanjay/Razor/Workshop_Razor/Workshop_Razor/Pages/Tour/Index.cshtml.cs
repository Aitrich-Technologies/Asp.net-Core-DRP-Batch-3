using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Workshop_Razor.Models;
using Workshop_Razor.Service;

namespace Workshop_Razor.Pages.Tour
{
    public class IndexModel : PageModel
    {
        private readonly TourService _service;
        public List<Tours> TourPosts { get; set; }

        public IndexModel(TourService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            TourPosts = await _service.GetAllTourAsync();
        }
    }
}
