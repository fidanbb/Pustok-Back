namespace Pustok_Backend.Models
{
    public class Testimonial:BaseEntity
    {
        public string Review { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
