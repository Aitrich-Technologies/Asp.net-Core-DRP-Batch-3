using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace sample_partial.Pages
{
    public class DemopageModel : PageModel
    {
        public string Message { get; set; }
        public void OnGet()
        {
            Message = "Page Loaded";
        }
        public void OnPost(string name)
        {
            Message = "Hello" + name;
        }
    }
}
