using Cashback.Domain.Model;
using Cashback.Service.Interface;
using Cashback.Spotify.Interface;
using Cashback.Spotify.Model;
using System.Collections.Generic;

namespace Cashback.Spotify
{
    public class SpotifyFacade : ISpotifyFacade
    {
        private ISpotifyFactory _factory;
        
        private ISpotifyTokenRequest tokenRequest;
        private ISpotifyService service;


        public SpotifyFacade(ISpotifyFactory factory)
        {
            _factory = factory;
        }

        public void PrepareEnvironment ()
        {
            // incializa classe de servi�os
            service = _factory.GetSpotifyService();

            // recupera valores do arquivo appsettings.json para requisitar token 
            tokenRequest = _factory.GetSpotifyTokenRequest();

            // recupera o token atrav�s da API do Spotify
            string access_token = service.GetToken(tokenRequest).Result;

            // obt�m lista de �lbuns da API do Spotify
            List<Album> list = service.GetAlbums(access_token);

            // incluir dados no BD
            throw new System.Exception("TODO - incluir dados no BD");
        }
    }
}