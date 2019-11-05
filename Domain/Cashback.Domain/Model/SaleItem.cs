using System;
using System.Collections.Generic;
using System.Text;

namespace Cashback.Domain.Model
{
    public class SaleItem : Entity
    {
        public Album Album { get; set; }
        public int Quantity { get; set; }
        public CashbackByDayOfWeek Cashback { get; set; }
        public decimal Value { get; set; }
    }
}
