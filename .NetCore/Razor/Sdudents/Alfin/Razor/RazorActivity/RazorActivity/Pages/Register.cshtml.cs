using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorActivity.Models;

namespace RazorActivity.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly AppDbContext _context;
        [BindProperty]
        public User NewUser { get; set; }
        public RegisterModel(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnPost()

        {
            if (string.IsNullOrEmpty(NewUser.UserName) || string.IsNullOrEmpty(NewUser.Password))
            {
                ModelState.AddModelError("", "Username and Password are required");
                return Page();
            }

            
            if (_context.Users.Any(u => u.UserName == NewUser.UserName))
            {
                ModelState.AddModelError("", "Username already taken");
                return Page();
            }

            _context.Users.Add(NewUser);
            _context.SaveChanges();
            return RedirectToPage("Login");
        }



    }
}
