namespace Pustok_Backend.Areas.Admin.ViewModels.Discount
{
    public class DiscountVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Percent { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
