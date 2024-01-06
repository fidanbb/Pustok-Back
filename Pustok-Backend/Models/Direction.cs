namespace Pustok_Backend.Models
{
    public class Direction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Slider> Sliders { get; set; }
    }
}
