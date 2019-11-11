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
    public class CashbackRepository : Repository<CashbackByDayOfWeek>, ICashbackRepository
    {
        public CashbackRepository(DatabaseContext context) : base(context)
        {
        }

        public CashbackByDayOfWeek Get(string musicStyle)
        {
            return base._dBSet
                .Where(x => x.MusicStyle.ToLower() == musicStyle.ToLower())
                .FirstOrDefault();
        }
        public void Migrate()
        {
            _context.Database.Migrate();
            _context.Database.EnsureCreated();
        }
    }
}
