using System;
using System.Collections.Generic;
using System.Text;

namespace Cashback.Spotify.Interface
{
    /// <summary>
    /// Aplicação do Design Pattern Factory
    /// Classe responsável por instanciar objetos de outras classes
    /// OBSERVAÇÃO: para manter o padrão de Injeção de Dependência
    /// já utilizado no projeto, não foi utilizado classe estática.
    /// </summary>
    public interface ISpotifyFactory
    {
        /// <summary>
        /// Recupera objeto com dados para requisição de Token
        /// </summary>
        /// <returns>Objeto do tipo ISpotifyTokenRequest</returns>
        ISpotifyTokenRequest GetSpotifyTokenRequest();

        /// <summary>
        /// Recupera objeto para acessar serviços da API do Spotify
        /// </summary>
        /// <returns>Implementação da interface ISpotifyService</returns>
        ISpotifyService GetSpotifyService();
    }
}
