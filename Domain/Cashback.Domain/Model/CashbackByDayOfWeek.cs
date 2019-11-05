using System;
using System.Collections.Generic;
using System.Text;

namespace Cashback.Domain.Model
{
    public class CashbackByDayOfWeek
    {
        public DayOfWeek DayOfWeek { get; set; }

        public MusicStyle MusicStyle { get; set; }

        public int Percentage { get; set; }
    }
}
