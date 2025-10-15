namespace CastingCallAPI.Models
{
    public class CastingCall
    {
        public Guid Id { get; set; }
        public string? CompanyName { get; set; }
        public string? CastingDirector { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Location { get; set; }
        public string? Ethnicity { get; set; }
        public string? Gender { get; set; }
        public string? Age { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? DueDate { get; set; }
    }
}
