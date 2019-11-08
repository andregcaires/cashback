using Cashback.Domain.Model;
using Cashback.Service.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cashback.Service.Interface
{
    /// <summary>
    /// Abstrai serviços relacionados ao Cashback
    /// </summary>
    public interface ICashbackService : IServiceContract<CashbackByDayOfWeek>
    {
        /// <summary>
        /// Inicializa dados na tabela de Cashback
        /// </summary>
        public void InitializeCashbackDatabase();
    }
}
