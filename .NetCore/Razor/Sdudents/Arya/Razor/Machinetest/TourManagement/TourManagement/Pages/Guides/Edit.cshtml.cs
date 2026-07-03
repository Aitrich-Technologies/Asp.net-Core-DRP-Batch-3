using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TourManagement.Interface;
using TourManagement.Models;

namespace TourManagement.Pages.Guides
{
    public class EditModel : PageModel
    {
        private readonly IUserService _userService;

        public EditModel(IUserService userService)
        {
            _userService = userService;
        }

        [BindProperty]
        public User User { get; set; }

        public async Task OnGetAsync(int id)
        {
            User = await _userService.GetUserByIdAsync(id);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _userService.UpdateUserAsync(User);
            return RedirectToPage("Index");
        }
    }
}