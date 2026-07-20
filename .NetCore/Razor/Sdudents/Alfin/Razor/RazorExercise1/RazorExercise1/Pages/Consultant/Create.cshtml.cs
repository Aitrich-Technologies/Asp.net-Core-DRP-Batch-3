using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorExercise1.Dto;
using RazorExercise1.Service;

namespace RazorExercise1.Pages.Consultant
{
    public class CreateModel : PageModel
    {
        private readonly ConsultantService _service;

        [BindProperty]
        public ConsultantDto ConsultantInfo { get; set; }

        public CreateModel(ConsultantService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var registerId = HttpContext.Session.GetInt32("RegisterId");
            if (registerId == null)
                return RedirectToPage("/Login");

            await _service.AddConsultantAsync(ConsultantInfo, registerId.Value);
            return RedirectToPage("Index");
        }
        
    }
}
