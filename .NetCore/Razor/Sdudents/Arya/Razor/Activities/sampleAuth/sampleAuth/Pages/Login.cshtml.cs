using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sampleAuth.Models;

namespace sampleAuth.Pages
{
    public class LoginModel : PageModel
    {

        private readonly AppDbContext _context;

        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public string password { get; set; }


        public LoginModel(AppDbContext context)
        {
            _context = context;

        }
        public IActionResult Onpost()
        {
            var user = _context.Users.SingleOrDefault(u => u.UserName == Username && u.password
             == password);
            if (user == null)
            {
                ModelState.AddModelError("", "username and password required");
                return Page();
            }

            HttpContext.Session.SetString("user", Username);
            return RedirectToPage("Index");


        }
    }
}