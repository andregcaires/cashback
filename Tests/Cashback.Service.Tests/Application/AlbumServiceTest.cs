using Cashback.Context;
using Cashback.Context.Repository;
using Cashback.Domain.Model;
using Cashback.Service.Tests.Mock;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Utilities;
using System.Linq;
using Xunit;
using Cashback.Service.Application;

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
                    Album album = new Album() { Name = "Teste", MusicStyle = "mpb" };
                    repository.Insert(album);
                    Assert.NotEqual(0, album.ID);
                }

                using (var context = new DatabaseContext(options))
                {
                    Assert.Equal(1, context.Albums.Count());

                    Album album = context.Albums.FirstOrDefault();

                    Assert.Equal("mpb", album.MusicStyle);
                    Assert.Equal("Teste", album.Name);
                }
            }
            finally
            {
                conn.Close();
            }
        }

        [Fact]
        public void Get_albums_through_pagination()
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

                    DataMock
                        .GenerateAlbums()
                        .ToList()
                        .ForEach(album => repository.Insert(album));
                }

                using (var context = new DatabaseContext(options))
                {
                    AlbumService service = new AlbumService(new AlbumRepository(context));
                    Assert.Equal(10, service.GetPaged(2, 10).Count());
                }
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
