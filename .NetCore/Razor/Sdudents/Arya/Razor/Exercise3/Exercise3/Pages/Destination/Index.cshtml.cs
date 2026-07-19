using Exercise3.Dto;
using Exercise3.Interface;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercise3.Pages.Destination
{
    public class IndexModel : PageModel
    {
        private readonly IDestinationService _service;

        public IndexModel(IDestinationService service)
        {
            _service = service;
        }

        public List<DestinationDto> Destinations { get; set; }

        public async Task OnGetAsync()
        {
            Destinations = await _service.GetAll();
        }
    }
}