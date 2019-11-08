using Cashback.Context.Mapping;
using Cashback.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cashback.Context
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<CashbackByDayOfWeek> Cashbacks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlbumMapping());
            modelBuilder.ApplyConfiguration(new CashbackMapping());

            base.OnModelCreating(modelBuilder);
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
    }
}
