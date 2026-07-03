using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TourManagement.Dto;
using TourManagement.Interface;

namespace TourManagement.Pages.Register
{
    public class LoginModel : PageModel
    {
        private readonly IUserService _userService;

        public LoginModel(IUserService userService)
        {
            _userService = userService;
        }

        [BindProperty]
        public LoginDto Login { get; set; }

        public string Message { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userService.LoginAsync(Login);

            if (user == null)
            {
                Message = "Invalid Username or Password";
                return Page();
            }

            return RedirectToPage("/Guides/Index");
        }
    }
}
