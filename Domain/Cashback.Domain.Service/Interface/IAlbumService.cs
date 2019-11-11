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

        /// <summary>
        /// Recupera itens do banco de forma paginada
        /// </summary>
        /// <param name="skip">Número da página</param>
        /// <param name="pageSize">Tamanho da página</param>
        /// <returns></returns>
        IList<Album> GetPaged(int skip, int pageSize, string musicStyle = "");

        /// <summary>
        /// Busca álbum no banco baseado em seu ID
        /// </summary>
        /// <param name="id">ID a ser pesquisado</param>
        /// <returns>Album pesquisado</returns>
        Album FindById(int id);
    }
}
