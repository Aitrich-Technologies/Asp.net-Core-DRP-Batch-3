namespace MVC_Exercise.Dto
{
    public class DestinationPatchDto
    {
        public string? Name { get; set; }      // nullable
        public string? City { get; set; }      // nullable
        public IFormFile? ImageFile { get; set; }  // nullable

    }
}
