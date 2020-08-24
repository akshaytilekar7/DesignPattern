﻿namespace CommandPatternCart.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ArticleId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
