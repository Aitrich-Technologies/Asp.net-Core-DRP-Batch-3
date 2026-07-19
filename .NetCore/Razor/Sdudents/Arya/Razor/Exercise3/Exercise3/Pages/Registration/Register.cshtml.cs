using Exercise3.Dto;
using Exercise3.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercise3.Pages.Registration
{
    public class RegisterModel : PageModel
    {
        private readonly IUserService _userService;

        public RegisterModel(IUserService userService)
        {
            _userService = userService;
        }

        [BindProperty]
        public string UserName { get; set; }


        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string Message { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            var result = await _userService.Register(new UserDto
            {
                UserName = UserName,
                Email = Email,
                Password = Password
            });

            if (!result)
            {
                Message = "User already exists!";
                return Page();
            }

            return RedirectToPage("/Registration/Login");
        }
    }
}
