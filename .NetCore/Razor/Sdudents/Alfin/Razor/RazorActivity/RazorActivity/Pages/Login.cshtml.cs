using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorActivity.Models;

namespace RazorActivity.Pages
{
    public class LoginModel : PageModel
    {
        private readonly AppDbContext _context;

        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public string Password { get; set; }

        public LoginModel(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnPost()
        {
            var user = _context.Users.SingleOrDefault(u => u.UserName == Username && u.Password == Password);
            if (user == null)
            {
                ModelState.AddModelError("", "Invalid username or password");
                return Page();
            }

            
            HttpContext.Session.SetString("User", Username);
            return RedirectToPage("Index");
        }
    }
}
