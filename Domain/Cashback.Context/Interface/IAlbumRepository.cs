using Cashback.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cashback.Context.Interface
{
    public interface IAlbumRepository : IRepository<Album>
    {
        /// <summary>
        /// Recupera todos os itens
        /// </summary>
        /// <returns>IQueryable de entidade do tipo T</returns>
        public IQueryable<Album> GetAllAsQueryable();
    }
}
