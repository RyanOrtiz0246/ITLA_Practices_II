namespace SalesDataAnalysisPlatformMVC.Data
{
    public class Sale
    {
        public int SaleID { get; set; }
        public int ClientID { get; set; }
        public DateTime DateSale { get; set; }
        public decimal Amount { get; set; }
    }
}
