using Cashback.Context.Interface;
using Cashback.Service.Util;
using Cashback.Domain.Model;
using Cashback.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using Utilities;

namespace Cashback.Service.Application
{
    public class CashbackService : ICashbackService
    {
        private ICashbackRepository _repo;
        public CashbackService(ICashbackRepository repo)
        {
            _repo = repo;
        }

        public void Add(CashbackByDayOfWeek item)
        {
            _repo.Insert(item);
        }

        public List<CashbackByDayOfWeek> SelectAll()
        {
            return _repo.GetAllAsList();
        }

        public IEnumerable<CashbackByDayOfWeek> GetCashbacksForToday()
        {
            return _repo.GetAllAsList()
                .Where(x => x.DayOfWeek == DateTime.Now.DayOfWeek.ToString().ToLower());
        }

        public void InitializeCashbackDatabase()
        {
            _repo.Migrate();
            if (_repo.GetAllAsList().Count == 0)
            {
                new List<CashbackByDayOfWeek>()
                    .AddRock()
                    .AddPop()
                    .AddMpb()
                    .AddClassic()
                    .ForEach(c => _repo.Insert(c));
            }

        }
    }
}
