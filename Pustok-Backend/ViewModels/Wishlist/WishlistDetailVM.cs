namespace Pustok_Backend.ViewModels.Wishlist
{
    public class WishlistDetailVM
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public int Discount { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public int StockCount { get; set; }
    }
}
