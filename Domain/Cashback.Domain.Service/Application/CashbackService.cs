﻿using Cashback.Context.Interface;
using Cashback.Service.Util;
using Cashback.Domain.Model;
using Cashback.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

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
            return _repo.GetAll();
        }

        public void InitializeCashbackDatabase()
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