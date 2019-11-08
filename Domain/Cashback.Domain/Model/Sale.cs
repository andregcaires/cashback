using System;
using System.Collections.Generic;
using System.Text;

namespace Cashback.Domain.Model
{
    public class Sale : Entity
    {
        public IEnumerable<SaleItem> SaleItems { get; set; }
        public DayOfWeek PurchaseDay { get; set; }
        public decimal TotalCashback { get; set; }
        public decimal TotalValue { get; set; }
    }
}
