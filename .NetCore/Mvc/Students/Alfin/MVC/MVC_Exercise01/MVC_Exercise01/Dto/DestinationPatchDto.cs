namespace MVC_Exercise01.Dto
{
    public class DestinationPatchDto
    {
        public string? Name { get; set; }
        public string? City { get; set; }
        public IFormFile? ImageFile { get; set; }
    }
}
