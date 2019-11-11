using Cashback.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cashback.Context.Interface
{
    public interface ICashbackRepository : IRepository<CashbackByDayOfWeek>
    {
        CashbackByDayOfWeek Get(string musicStyle);

        void Migrate();
    }
}
