using System;
using System.Collections.Generic;
using System.Text;

namespace Cashback.Spotify.Interface
{
    /// <summary>
    /// Representa o corpo da requisição necessária para recuperar Token da API do Spotify
    /// </summary>
    public interface ISpotifyTokenRequest
    {
        /// <summary>
        /// Retorna ClientId e ClientSecret formatados para uso em header Authorization
        /// </summary>
        /// <returns></returns>
        string ToAuthorization();

        /// <summary>
        /// Retorna GrantType
        /// </summary>
        /// <returns>String recuperada de appsettings.json</returns>
        string GetGrantType();
    }
}
