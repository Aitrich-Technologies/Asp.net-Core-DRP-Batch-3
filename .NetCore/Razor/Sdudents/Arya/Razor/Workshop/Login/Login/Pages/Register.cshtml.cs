using Login.Dtos;
using Login.Interfacce;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Login.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly IUserService _userService;

        public RegisterModel(IUserService userService)
        {
            _userService = userService;
        }

        [BindProperty]
        public UserRegisterDto RegisterDto { get; set; } = new();

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var result = await _userService.RegisterAsync(RegisterDto);

            if (!result)
            {
                ModelState.AddModelError("", "Username already exists");
                return Page();
            }

            return RedirectToPage("/Login");
        }
    }
}