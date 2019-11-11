using Cashback.Context.Interface;
using Cashback.Domain.Model;
using Cashback.Service.DTO;
using Cashback.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;

namespace Cashback.Service.Application
{
    public class SaleService : ISaleService
    {
        private ISaleRepository _repo;
        private ICashbackService _cashbackService;
        private IAlbumService _albumService;
        public SaleService (ISaleRepository repo, ICashbackService cashbackService, IAlbumService albumService)
        {
            _repo = repo;
            _cashbackService = cashbackService;
            _albumService = albumService;
        }

        public void Add(Sale item)
        {
            _repo.Insert(item);
        }

        public int RegisterSale(List<AlbumDTO> albumDto)
        {
            // recupera cashbacks baseados na data atual
            var cashbacks = _cashbackService.GetCashbacksForToday();

            // busca álbuns relacionados aos IDs informados
            List<SaleItem> listSaleItems = new List<SaleItem>();
            StringBuilder notFound = new StringBuilder("");

            albumDto.ForEach(dto =>
            {
                var album = _albumService.FindById(dto.ID);
                if (album != null)
                {
                    var cashback = GetCashback(album, cashbacks);

                    SaleItem saleItem = new SaleItem();
                    saleItem.Quantity = dto.Quantity;
                    saleItem.Album = album;
                    saleItem.CashbackUnitaryValue = cashback;
                    saleItem.CashbackTotalValue = cashback * dto.Quantity;
                    saleItem.TotalValue = album.Price * dto.Quantity;
                    saleItem.UnitaryValue = album.Price;

                    listSaleItems.Add(saleItem);
                }
                else
                    notFound.Append($"{dto.ID} ");
            });

            if (notFound.Length > 0)
                throw new Exception($"There where invalid IDs: {notFound.ToString()}");

            Sale sale = new Sale();
            sale.SaleItems = listSaleItems;
            sale.PurchaseDay = DateTime.Today.DayOfWeek.ToString().ToLower();
            sale.TotalValue = sale.SaleItems.Sum(x => x.TotalValue);
            sale.TotalCashback = sale.SaleItems.Sum(x => x.CashbackTotalValue);
            sale.PurchaseDate = DateTime.Now;

            Add(sale);

            return sale.ID;
        }

        private decimal GetCashback(Album album, IEnumerable<CashbackByDayOfWeek> cashbacks)
        {
            decimal percentage = cashbacks.Where(x => x.MusicStyle == album.MusicStyle).FirstOrDefault().Percentage;
            var result = (percentage / 100M) * album.Price;
            
            return decimal.Round(result, 2, MidpointRounding.AwayFromZero);
        }

        public List<Sale> SelectAll()
        {
            return _repo.GetAllQueryable().ToList();
        }

        public Sale FindById(int id)
        {
            return _repo.GetById(id);
        }

        public IList<Sale> GetPaged(int skip, int pageSize, DateTime initialDate, DateTime endDate)
        {
            //throw new NotImplementedException();
            Func<Sale, bool> condition = GetCondition(initialDate, endDate);

            return _repo
                .GetAllQueryable()
                .Where(condition)
                .GetPaged(skip, pageSize)
                .Results;
        }

        private Func<Sale, bool> GetCondition(DateTime initialDate, DateTime endDate)
        {
            if (initialDate != null && endDate != null)
                return new Func<Sale, bool>(x => DateTime.Compare(x.PurchaseDate, initialDate) >= 0
                        && DateTime.Compare(x.PurchaseDate, endDate) <= 0);
            else if (initialDate != null && endDate == null)
                return new Func<Sale, bool>(x => DateTime.Compare(x.PurchaseDate, initialDate) >= 0);
            else if (initialDate == null && endDate != null)
                return new Func<Sale, bool>(x => DateTime.Compare(x.PurchaseDate, endDate) <= 0);
            else
                return new Func<Sale, bool>(x => true);
        }

    }
}
