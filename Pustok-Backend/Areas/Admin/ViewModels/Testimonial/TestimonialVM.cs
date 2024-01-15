namespace Pustok_Backend.Areas.Admin.ViewModels.Testimonial
{
    public class TestimonialVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Image { get; set; }
        public string Review { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
