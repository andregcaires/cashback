using Cashback.Context;
using Cashback.Context.Repository;
using Cashback.Service.Application;
using Cashback.Service.DTO;
using Cashback.Service.Tests.Mock;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using Utilities;

namespace Cashback.Service.Tests.Application
{
    public class SaleServiceTest
    {
        [Fact]
        public void Add_sale()
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
                    CashbackService cashbackService = new CashbackService(new CashbackRepository(context));
                    cashbackService.InitializeCashbackDatabase();

                    AlbumService albumService = new AlbumService(new AlbumRepository(context));

                    DataMock
                        .GenerateAlbums()
                        .ToList()
                        .ForEach(album => albumService.Add(album));

                    var albums = albumService.GetPaged(1, 5).ToList();

                    List<AlbumDTO> dtos = new List<AlbumDTO>();

                    albums.ForEach(x => dtos.Add(x.ConvertTo(typeof(AlbumDTO))));

                    SaleService saleService = new SaleService(new SaleRepository(context), cashbackService, albumService);

                    int insertedId = saleService.RegisterSale(dtos);

                    Assert.Equal(1, insertedId);
                }

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
