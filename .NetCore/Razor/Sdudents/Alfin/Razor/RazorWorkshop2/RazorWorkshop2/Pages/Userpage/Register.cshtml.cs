using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorWorkshop2.Dtos;
using RazorWorkshop2.Interfaces;

namespace RazorWorkshop2.Pages.Userpage
{
    public class RegisterModel : PageModel
    {

        private readonly IUserService _userService;
        public RegisterModel(IUserService userService)
        {
            _userService = userService;
        }

        [BindProperty]
        public UserRegisterDto RegisterDto { get; set; } = new UserRegisterDto();

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            bool success = await _userService.RegisterAsync(RegisterDto);
            if (!success)
            {
                ModelState.AddModelError(string.Empty, "Username already exist.");
                return Page();
            }
            TempData["SuccessMessage"] = "Register Successful.Please login.";
            return RedirectToPage("Login");
        }

    }
}
