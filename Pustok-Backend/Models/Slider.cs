namespace Pustok_Backend.Models
{
    public class Slider:BaseEntity
    {
        public string Header { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public int DirectionId { get; set; }
        public Direction Direction { get; set; }
    }
}
