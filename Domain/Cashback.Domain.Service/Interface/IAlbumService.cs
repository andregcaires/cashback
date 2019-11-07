using Cashback.Context.Interface;
using Cashback.Domain.Model;
using Cashback.Service.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cashback.Service.Interface
{
    /// <summary>
    /// Abstrai serviços relacionados a Album
    /// </summary>
    public interface IAlbumService : IServiceContract<Album>
    {
        /// <summary>
        /// Insere lista de álbuns obtidas da API no banco de dados
        /// </summary>
        /// <param name="albumList">Lista de álbuns</param>
        void AddAlbumsToDatabase(List<Album> albumList);
    }
}
