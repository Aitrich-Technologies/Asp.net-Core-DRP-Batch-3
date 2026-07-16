using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Activity.Pages
{
    public class BookingModel : PageModel
    {
        
            public string CustomerName { get; set; } = "";
            public string Email { get; set; } = "";
            public string MobileNumber { get; set; } = "";
            public int PackageId { get; set; }
            public DateTime TravelDate { get; set; }
            public int NumberOfPersons { get; set; }
            public string SpecialRequests { get; set; } = "";
            public void OnGet()
        { }
        }
    }

