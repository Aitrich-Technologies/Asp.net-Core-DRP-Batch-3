using Exercise3.Dto;
using Exercise3.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercise3.Pages.Registration
{
    public class LoginModel : PageModel
    {
        private readonly IUserService _userService;

        public LoginModel(IUserService userService)
        {
            _userService = userService;
        }

        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string Message { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userService.Login(new LoginDto
            {
                Email = Email,
                Password = Password
            });

            if (user == null)
            {
                Message = "Invalid login";
                return Page();
            }

            return RedirectToPage("/Destination/Index");
        }
    }
}