using Cashback.Domain.Model;
using Cashback.Service.Contract;
using Cashback.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cashback.Service.Interface
{
    /// <summary>
    /// Abstrai serviços relacionados à venda
    /// </summary>
    public interface ISaleService : IServiceContract<Sale>
    {
        /// <summary>
        /// Recupera vendas de forma paginada
        /// </summary>
        /// <param name="skip">Número da página</param>
        /// <param name="pageSize">Tamanho da página</param>
        /// <param name="initialDate">Data inicial de filtro</param>
        /// <param name="endDate">Data final de filtro</param>
        /// <returns>IList de vendas paginadas e ordenadas</returns>
        IList<Sale> GetPaged(int skip, int pageSize, DateTime initialDate, DateTime endDate);

        /// <summary>
        /// Registra nova venda com base em lista de objetos obtidos na API
        /// </summary>
        /// <param name="albumDto">Lista de objetos contendo ID do album e sua quantidade</param>
        /// <returns>ID da nova venda registrada</returns>
        int RegisterSale(List<AlbumDTO> albumDto);

        /// <summary>
        /// Busca venda com base em seu ID
        /// </summary>
        /// <param name="id">ID a ser pesquisado</param>
        /// <returns>Venda resultante da pesquisa</returns>
        Sale FindById(int id);
    }
}
