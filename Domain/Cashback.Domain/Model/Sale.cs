using System;
using System.Collections.Generic;
using System.Text;

namespace Cashback.Domain.Model
{
    public class Sale : Entity
    {
        public string PurchaseDay { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal TotalCashback { get; set; }
        public decimal TotalValue { get; set; }
        public virtual List<SaleItem> SaleItems { get; set; }

        public static Sale New()
        {
            return new Sale() { 
                
            };
        }
    }
}
