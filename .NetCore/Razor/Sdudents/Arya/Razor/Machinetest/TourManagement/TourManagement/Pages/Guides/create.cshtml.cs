using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TourManagement.Interface;
using TourManagement.Models;
using TourManagement.Dto;

namespace TourManagement.Pages.Guides
{
    public class CreateModel : PageModel
    {
        private readonly IGuideService _guideService;

        public CreateModel(IGuideService guideService)
        {
            _guideService = guideService;
        }

        [BindProperty]
        public Guide Guide { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            
            var guideDto = new GuideDto
            {
                GuideName = Guide.GuideName,
                PhoneNumber = Guide.PhoneNumber,
                Experience = Guide.Experience,
                Langauage = Guide.Langauage
            };

            await _guideService.AddGuideAsync(guideDto);

            return RedirectToPage("Index");
        }
    }
}