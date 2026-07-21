using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorMachineTest2.Dtos;
using RazorMachineTest2.Interface;

namespace RazorMachineTest2.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly IUserService _userService;
        public RegisterModel(IUserService userService)
        {
            _userService = userService;
        }

        [BindProperty]
        public RegisterDto RegisterDto { get; set; } = new RegisterDto();

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
