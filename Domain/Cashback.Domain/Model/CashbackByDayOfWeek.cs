using System;
using System.Collections.Generic;
using System.Text;

namespace Cashback.Domain.Model
{
    public class CashbackByDayOfWeek : Entity
    {
        public DayOfWeek DayOfWeek { get; set; }

        public string MusicStyle { get; set; }

        public int Percentage { get; set; }
    }
}
