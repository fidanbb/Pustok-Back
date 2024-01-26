namespace Pustok_Backend.Helpers.Responses
{
    public class IncreaseOrDecreaseCountResponse
    {
        public int Count { get; set; }
        public decimal GrandTotal { get; set; }
        public decimal ProductTotalPrice { get; set; }
        public int CountBasket { get; set; }
    }
}
