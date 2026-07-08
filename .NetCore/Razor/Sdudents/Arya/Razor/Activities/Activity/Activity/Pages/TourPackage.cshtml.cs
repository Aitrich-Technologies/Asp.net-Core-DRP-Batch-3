using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Activity.Pages
{
    public class TourPackageModel : PageModel
    {

        public int PackageID { get; set; }
        public string PackageName { get; set; } = "";
        public string Destination { get; set; } = "";
        public decimal Price { get; set; }
        public int Duration { get; set; }
        public void OnGet()
        {
        }
    }
}
