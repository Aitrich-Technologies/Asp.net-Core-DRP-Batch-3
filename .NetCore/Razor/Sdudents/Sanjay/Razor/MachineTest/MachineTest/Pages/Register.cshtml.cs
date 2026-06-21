using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MachineTest.Service;
using MachineTest.Dto;
using MachineTest.Interface;
namespace MachineTest.Pages
{
    public class RegisterModel : PageModel
    {
        public readonly IUserService _userService;

        [BindProperty]
        public UserDto userDto { get; set; } = new UserDto();
        public RegisterModel(IUserService userService)
        {
            _userService = userService;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            bool success = await _userService.RegisterAsync(userDto);
            if (!success)
            {
                ModelState.AddModelError(string.Empty, "Username already exists.");
                return Page();
            }
            return RedirectToPage("Login");
        }
    }
}
