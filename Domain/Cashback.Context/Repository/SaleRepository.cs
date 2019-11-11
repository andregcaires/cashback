using Cashback.Context.Commom;
using Cashback.Context.Interface;
using Cashback.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cashback.Context.Repository
{
    public class SaleRepository : Repository<Sale>, ISaleRepository
    {
        public SaleRepository(DatabaseContext context) : base(context)
        {
        }

        public IQueryable<Sale> GetAllQueryable()
        {
            return _dBSet
                .Include(x => x.SaleItems)
                .ThenInclude(x => x.Album)
                .OrderByDescending(x => x.PurchaseDay);
        }
    }
}
