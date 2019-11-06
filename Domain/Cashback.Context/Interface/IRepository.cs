using System;
using System.Collections.Generic;
using System.Text;

namespace Cashback.Context.Interface
{
    /// <summary>
    /// Fornece métodos comuns de CRUD
    /// </summary>
    /// <typeparam name="T">Classe de entidade</typeparam>
    public interface IRepository<T>
    {
        /// <summary>
        /// Recupera todos os itens
        /// </summary>
        /// <returns>Lista de entidade do tipo T</returns>
        public List<T> GetAll();

        /// <summary>
        /// Recupera item do banco pelo seu ID
        /// </summary>
        /// <param name="id">ID do tipo int do objeto</param>
        /// <returns>Objeto do tipo T</returns>
        T GetById(int id);

        /// <summary>
        /// Insere novo item no banco de dados
        /// </summary>
        /// <param name="instance">Objeto do tipo T a ser inserido</param>
        void Insert(T instance);

        /// <summary>
        /// Atualiza item existente no banco de dados
        /// </summary>
        /// <param name="instance">Objeto do tipo T a ser atualizado</param>
        void Update(T instance);

        /// <summary>
        /// Remove item do banco de dados
        /// </summary>
        /// <param name="instance">Objeto do tipo T a ser deletado</param>
        void Delete(T instance);
    }
}
