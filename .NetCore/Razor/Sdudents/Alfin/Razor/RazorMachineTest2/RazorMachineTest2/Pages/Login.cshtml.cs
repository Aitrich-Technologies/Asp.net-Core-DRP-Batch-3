using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorMachineTest2.Dtos;
using RazorMachineTest2.Interface;

namespace RazorMachineTest2.Pages
{
    public class LoginModel : PageModel
    {
        private readonly IUserService _userService;

        public LoginModel(IUserService userService)
        {
            _userService = userService;
        }

        [BindProperty]
        public LoginDto LoginDto { get; set; } = new LoginDto();

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await _userService.LoginAsync(LoginDto);
            if (user == null)
            {
                TempData["ErrorMessage"] = "Invalid username or password.";
                return Page();
            }

            HttpContext.Session.SetString("UserId", user.Id.ToString());
            HttpContext.Session.SetString("UserName", user.UserName);

            return RedirectToPage("/Vehicles/Index");
        }
    }
}
