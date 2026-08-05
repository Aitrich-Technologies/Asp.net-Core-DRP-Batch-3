namespace MVC_Workshop01.Dto
{
    public class CreateBookingDto
    {
       
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string?  Gender { get; set; }
        public DateOnly? Dob { get; set; }
        public string? Citizenship { get; set; }
        public string? PassportNumber { get; set; }
        public DateOnly? IssueDate { get; set; }
        public DateOnly? ExpiryDate { get; set; }
        public string? PlaceOfBirth { get; set; }
        public bool LeadPassenger { get; set; }
        public string ParticipantType { get; set; }
        public string Status { get; set; }
    }
}
