using Cashback.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cashback.Service.Contract
{
    /// <summary>
    /// Fornece métodos comuns a serem aplicados em classes de serviços
    /// </summary>
    /// <typeparam name="T">Classe de entidade</typeparam>
    public interface IServiceContract<T> where T : Entity
    {
        /// <summary>
        /// Insere novo item no banco de dados
        /// </summary>
        /// <param name="item">Entidade</param>
        void Add(T item);

        /// <summary>
        /// Seleciona todos os itens do banco
        /// </summary>
        /// <returns>Lista contendo entidades do tipo T</returns>
        List<T> SelectAll();

        /// <summary>
        /// Recupera itens do banco de forma paginada
        /// </summary>
        /// <param name="skip">Número da página</param>
        /// <param name="pageSize">Tamanho da página</param>
        /// <returns></returns>
        IList<T> GetPaged(int skip, int pageSize);
    }
}
