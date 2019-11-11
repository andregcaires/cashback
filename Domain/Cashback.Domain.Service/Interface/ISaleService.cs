using Cashback.Domain.Model;
using Cashback.Service.Contract;
using Cashback.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cashback.Service.Interface
{
    public interface ISaleService : IServiceContract<Sale>
    {
        IList<Sale> GetPaged(int skip, int pageSize, DateTime initialDate, DateTime endDate);

        int RegisterSale(List<AlbumDTO> albumDto);

        Sale FindById(int id);
    }
}
