using Cashback.Context.Commom;
using Cashback.Context.Interface;
using Cashback.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cashback.Context.Repository
{
    public class CashbackRepository : Repository<CashbackByDayOfWeek>, ICashbackRepository
    {
        public CashbackRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
