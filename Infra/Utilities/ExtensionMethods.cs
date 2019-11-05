using Newtonsoft.Json;
using System;
using System.Reflection;


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
    }
}