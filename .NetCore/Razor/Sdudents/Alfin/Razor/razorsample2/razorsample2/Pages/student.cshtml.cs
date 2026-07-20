using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razorsample2.Pages
{
    public class studentModel : PageModel
    {
        public string message { get; set; }

        public void OnGet()
        {
            message = "messaged";
        }
        public void OnPost(string name)
        {
            message = "hello" + name;
        }
    }
}
