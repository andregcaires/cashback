using Cashback.Context;
using Cashback.Context.Interface;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
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
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
