using Cashback.Domain.Model;
using Cashback.Service.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cashback.Service.Interface
{
    public interface ICashbackService : IServiceContract<CashbackByDayOfWeek>
    {
        public void InitializeCashbackDatabase();
    }
}
