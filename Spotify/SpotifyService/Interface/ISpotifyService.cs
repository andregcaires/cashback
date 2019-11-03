using Cashback.Spotify.Model;
using Cashback.Spotify.Token;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cashback.Spotify.Interface
{
    /// <summary>
    /// Serviços para uso da API do Spotify
    /// </summary>
    public interface ISpotifyService
    {
        /// <summary>
        /// Recupera token com base nos dados em appsettings.json
        /// </summary>
        /// <param name="req">Objeto inicializado com valores do arquivo json</param>
        /// <returns>Token de acesso</returns>
        Task<string> GetToken(ISpotifyTokenRequest req);

        /// <summary>
        /// Busca álbuns na API do Spotify
        /// </summary>
        /// <param name="access_token">Token de acesso obtido em GetToken</param>
        /// <returns>Lista de respostas obtidas da chamada convertidas em objetos SpotifyAlbumResponse</returns>
        IEnumerable<SpotifyAlbumResponse> GetAlbums(string access_token);
    }
}
