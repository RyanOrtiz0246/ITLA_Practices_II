using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace SalesDataAnalysisPlatformMVC.Data
{
    [Table("SalesDB")]
    public class Sale
    {
        public int SaleID { get; set; }
        public int ClientID { get; set; }
        public DateTime DateSale { get; set; }
        public decimal Amount { get; set; }
    }
}
