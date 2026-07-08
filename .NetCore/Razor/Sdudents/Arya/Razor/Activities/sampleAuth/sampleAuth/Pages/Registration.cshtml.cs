using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sampleAuth.Models;

namespace sampleAuth.Pages
{
    public class RegistrationModel : PageModel
    {
        private readonly AppDbContext _context;

        [BindProperty]
        public User Newuser { get; set; }

        public RegistrationModel (AppDbContext context)
        {
            _context = context;

        }
        public IActionResult Onpost()
        {
            if(string.IsNullOrEmpty(Newuser.UserName) || string.IsNullOrEmpty(Newuser.password))
            {
                ModelState.AddModelError("", "username and password required");
                return Page ();
            }
            if (_context.Users.Any(u => u.UserName == Newuser.UserName))
            {
                ModelState.AddModelError("", "username already taken");
                return Page();
            }
            _context.Users.Add(Newuser);
            _context.SaveChanges();
            return RedirectToPage("Login");
        }
    }
}
