﻿namespace SalesAnalysisPlatform.Domain.Entities
{
    public class Sale
    {
        public int Id { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime SaleDate { get; set; } = DateTime.Now;
    }
}
