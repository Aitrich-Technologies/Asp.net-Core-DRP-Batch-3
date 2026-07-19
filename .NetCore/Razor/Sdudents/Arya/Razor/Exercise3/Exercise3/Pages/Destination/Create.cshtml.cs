using Exercise3.Dto;
using Exercise3.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercise3.Pages.Destination
{
    public class CreateModel : PageModel
    {
        private readonly IDestinationService _service;
        private readonly IWebHostEnvironment _env;

        public CreateModel(IDestinationService service, IWebHostEnvironment env)
        {
            _service = service;
            _env = env;
        }

        [BindProperty]
        public DestinationDto Destination { get; set; }

        [BindProperty]
        public IFormFile ImageFile { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            // default = no image
            string fileName = null;

            if (ImageFile != null && ImageFile.Length > 0)
            {
                // folder path
                string folder = Path.Combine(_env.WebRootPath, "images", "destinations");

                // ensure folder exists
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                // unique file name
                fileName = Guid.NewGuid() + Path.GetExtension(ImageFile.FileName);

                string filePath = Path.Combine(folder, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await ImageFile.CopyToAsync(stream);
                }

                Destination.ImagePath = fileName;
            }

            await _service.Add(Destination);

            return RedirectToPage("./Index");
        }
    }
}