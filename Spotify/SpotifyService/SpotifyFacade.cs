using Cashback.Spotify.Interface;
using Cashback.Spotify.Model;
using Cashback.Spotify.Token;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace Cashback.Spotify
{
    public class SpotifyFacade : ISpotifyFacade
    {
        private ISpotifyFactory _factory;
        
        private ISpotifyTokenRequest tokenRequest;
        private ISpotifyService service;
        private IConfiguration _config;

        public SpotifyFacade(ISpotifyFactory factory, IConfiguration config)
        {
            _factory = factory;
            _config = config;
        }

        public void PrepareEnvironment ()
        {
            // incializa classe de serviços
            service = _factory.GetSpotifyService();

            // recupera valores do arquivo appsettings.json para requisitar token 
            tokenRequest = _factory.GetSpotifyTokenRequest();

            // recupera o token através da API do Spotify
            string access_token = service.GetToken(tokenRequest).Result;

            List<SpotifyAlbumResponse> list = new List<SpotifyAlbumResponse>();
            list.AddRange(service.GetAlbums(access_token));

            System.Console.WriteLine(access_token);

            // incluir dados no BD
        }
    }
}