using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection.Emit;
using System.Xml.Linq;

namespace Activity1.Pages
{
    public class TourpackageModel : PageModel
    {

        public int PackageId;
        [BindProperty]
        public string PackageName { get; set; }
        public string Destination;
        public int Price;
        public string Duration;
        public void OnGet()
        {
            PackageId = 1;
            PackageName = "Kerala Tour";
            Destination = "Kerala";
            Price = 50000;
            Duration = "7 Days";
        }



    }
}
