using Cashback.Context;
using Cashback.Context.Interface;
using Cashback.Context.Repository;
using Cashback.Domain.Model;
using Cashback.Service.Application;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Xunit;

namespace Cashback.Service.Tests.Application
{
    public class AlbumServiceTest
    {
        [Fact]
        public void Add_album_to_database()
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
                    var repository = new AlbumRepository(context);
                    repository.Insert(new Album() { Name="Teste", MusicStyle="mpb" });
                }

                using (var context = new DatabaseContext(options))
                {
                    Assert.Equal(1, context.Albums.Count());
                }
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
