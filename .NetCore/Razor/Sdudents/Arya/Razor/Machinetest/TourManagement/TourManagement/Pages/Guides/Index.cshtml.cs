using Microsoft.AspNetCore.Mvc.RazorPages;
using TourManagement.Interface;
using TourManagement.Models;

namespace TourManagement.Pages.Guides
{
    public class IndexModel : PageModel
    {
        private readonly IGuideService _guideService;

        public IndexModel(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public List<Guide> Guides { get; set; } = new();

        public async Task OnGetAsync()
        {
            Guides = await _guideService.GetAllGuidesAsync();
        }
    }
}