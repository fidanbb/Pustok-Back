﻿namespace Pustok_Backend.ViewModels.Cart
{
    public class CartDetailVM
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Discount { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
    }
}
