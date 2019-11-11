using Cashback.Context;
using Cashback.Context.Repository;
using Cashback.Service.Application;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Cashback.Service.Tests.Application
{
    [Collection("Database connection")]
    public class CashbackServiceTest
    {
        [Fact]
        public void Initialize_items()
        {
            var conn = new SqliteConnection("DataSource=:memory:");
            conn.Open();

            try
            {
                var options = new DbContextOptionsBuilder<DatabaseContext>()
                    .UseSqlite(conn)
                    .Options;

                using (var context = new DatabaseContext(options))
                {
                    context.Database.EnsureCreated();
                }

                using (var context = new DatabaseContext(options))
                {
                    CashbackService service = new CashbackService(new CashbackRepository(context));
                    service.InitializeCashbackDatabase();
                }

                using (var context = new DatabaseContext(options))
                {
                    Assert.Equal(28, context.Cashbacks.Count());
                }
            }
            finally
            {
                conn.Close();
            }
        }

        [Fact]
        public void Get_cashbacks_for_today()
        {
            var conn = new SqliteConnection("DataSource=:memory:");
            conn.Open();

            try
            {
                var options = new DbContextOptionsBuilder<DatabaseContext>()
                    .UseSqlite(conn)
                    .Options;

                using (var context = new DatabaseContext(options))
                {
                    context.Database.EnsureCreated();
                }

                using (var context = new DatabaseContext(options))
                {
                    CashbackService service = new CashbackService(new CashbackRepository(context));
                    service.InitializeCashbackDatabase();
                }

                using (var context = new DatabaseContext(options))
                {
                    CashbackService service = new CashbackService(new CashbackRepository(context));
                    var forToday = service.GetCashbacksForToday();
                    Assert.NotEmpty(forToday);
                }
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
