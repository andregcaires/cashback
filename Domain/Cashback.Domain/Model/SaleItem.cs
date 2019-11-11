using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cashback.Domain.Model
{
    public class SaleItem : Entity
    {
        public decimal UnitaryValue { get; set; }
        public decimal CashbackUnitaryValue { get; set; }        
        public decimal TotalValue { get; set; }
        public decimal CashbackTotalValue { get; set; }
        public int Quantity { get; set; }
        [JsonIgnore]
        public virtual Sale Sale { get; set; }
        public virtual Album Album { get; set; }
        public virtual int AlbumID { get; set; }
        public virtual int SaleID { get; set; }

    }
}
