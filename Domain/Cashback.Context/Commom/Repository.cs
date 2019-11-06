using Cashback.Context.Interface;
using Cashback.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public void Delete(T instance)
        {

            _dBSet.Remove(instance);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _dBSet.ToList();
        }

        public T GetById(int id)
        {
            return _dBSet.Find(id);
        }

        public void Insert(T instance)
        {
            _dBSet.Add(instance);
            _context.SaveChanges();
        }

        public void Update(T instance)
        {
            _context.Entry(instance).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
