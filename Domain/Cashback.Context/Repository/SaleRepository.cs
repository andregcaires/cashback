using Cashback.Context.Commom;
using Cashback.Context.Interface;
using Cashback.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cashback.Context.Repository
{
    public class SaleRepository : Repository<Sale>, ISaleRepository
    {
        public SaleRepository(DatabaseContext context) : base(context)
        {
        }


    }
}
