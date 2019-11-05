using Cashback.Context.Interface;
using Cashback.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cashback.Context.Commom
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private DatabaseContext _context;
        private DbSet<T> _dBSet;
        public Repository(DatabaseContext context)
        {
            _context = context;
            _dBSet = _context.Set<T>();
        }
    }
}
