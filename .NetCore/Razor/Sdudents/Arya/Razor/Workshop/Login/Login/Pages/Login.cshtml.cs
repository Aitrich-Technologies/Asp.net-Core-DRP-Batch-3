using Login.Dtos;
using Login.Interfacce;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Login.Pages
{
    public class LoginModel : PageModel
    {
        private readonly IUserService _userService;

        public LoginModel(IUserService userService)
        {
            _userService = userService;
        }

        [BindProperty]
        public UserLoginDto LoginDto { get; set; } = new();

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userService.LoginAsync(LoginDto);

            if (user == null)
            {
                TempData["ErrorMessage"] = "Invalid Username or Password";
                return Page();
            }

            return RedirectToPage("/Index");
        }
    }
}