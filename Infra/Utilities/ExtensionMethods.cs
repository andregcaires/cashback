using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Utilities.Pagination;

namespace Utilities
{
    /// <summary>
    /// Fornece m�todos de extens�o utilit�rios
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Serializa objeto tipado em formato JSON
        /// </summary>
        /// <typeparam name="T">Tipo gen�rico</typeparam>
        /// <param name="reference">Objeto tipado</param>
        /// <returns>String em formato JSON</returns>
        public static string ToJson<T>(this T reference) => JsonConvert.SerializeObject(reference);

        /// <summary>
        /// Deserializa JSON para objeto tipado
        /// </summary>
        /// <typeparam name="T">Tipo gen�rico</typeparam>
        /// <param name="json">String em formato JSON</param>
        /// <returns>Objeto de tipo T com os valores do JSON</returns>
        public static T JsonToObject<T>(this string json) => JsonConvert.DeserializeObject<T>(json);
        

        /// <summary>
        /// Converte objeto de um tipo em outro. � necess�rio que os nomes das propriedades sejam as mesmas
        /// N�o realiza convers�o de m�todos, apenas propriedades.
        /// </summary>
        /// <typeparam name="T1">Classe do objeto origem</typeparam>
        /// <param name="source">Objeto de origem</param>
        /// <param name="targetType">Tipo do objeto de retorno, exemplo: typeof(<NomeDaClasse>)</param>
        /// <returns>Novo objeto do tipo especificado como argumento (targetType)</returns>
        public static dynamic ConvertTo<T1>(this T1 source, Type targetType)
        {
            var result = Activator.CreateInstance(targetType);
            foreach (PropertyInfo sourceProp in source.GetType().GetProperties())
            {
                foreach (PropertyInfo targetProp in result.GetType().GetProperties())
                {
                    if (sourceProp.Name == targetProp.Name)
                    {
                        targetProp.SetValue(result, sourceProp.GetValue(source));
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Gera resultado paginado de uma query do Entity Framework
        /// Refer�ncia: https://gunnarpeipman.com/ef-core-paging/
        /// </summary>
        /// <typeparam name="T">Classe de Entidade</typeparam>
        /// <param name="query">Objeto IQueryable do EF</param>
        /// <param name="page">N�mero da p�gina</param>
        /// <param name="pageSize">Tamanho da p�gina</param>
        /// <returns>Objeto do tipo PagedResult paginado</returns>
        public static PagedResult<T> GetPaged<T>(this IEnumerable<T> query,
                                                 int page = 0, int pageSize = 10) where T : class
        {
            var result = new PagedResult<T>();
            result.CurrentPage = page;
            result.PageSize = pageSize;
            result.RowCount = query.Count();

            var pageCount = (double)result.RowCount / pageSize;
            result.PageCount = (int)Math.Ceiling(pageCount);

            var skip = (page - 1) * pageSize;
            result.Results = query.Skip(skip).Take(pageSize).ToList();

            return result;
        }

    }
}