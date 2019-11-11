using Cashback.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cashback.Context.Interface
{
    public interface ISaleRepository : IRepository<Sale>
    {
        IQueryable<Sale> GetAllQueryable();
    }
}
