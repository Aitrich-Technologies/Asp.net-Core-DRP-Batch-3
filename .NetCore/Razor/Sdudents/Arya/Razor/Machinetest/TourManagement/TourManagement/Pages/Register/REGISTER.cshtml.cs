using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TourManagement.Dto;
using TourManagement.Interface;

namespace TourManagement.Pages.Register
{
    public class REGISTERModel : PageModel
    {
        private readonly IUserService _userService;

        public REGISTERModel(IUserService userService)
        {
            _userService = userService;
        }

        [BindProperty]
        public string UserName { get; set; } = string.Empty;

        [BindProperty]
        public string Password { get; set; } = string.Empty;

        public string Message { get; set; } = string.Empty;

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto = new RegisterDto
            {
                UserName = UserName,
                Password = Password
            };

            await _userService.RegisterAsync(dto);

            Message = "Registration Successful";

            return RedirectToPage("Login");
        }
    }
}

