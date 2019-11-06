using Cashback.Context.Interface;
using Cashback.DI.Interface;
using Cashback.Domain.Model;
using Cashback.Service.Interface;
using Cashback.Spotify.Interface;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cashback.DI
{
    public class BootstrapFacade : IBootstrapFacade
    {
        private ISpotifyFactory _factory;
        private ISpotifyTokenRequest tokenRequest;
        private ISpotifyService spotifyService;

        private ICashbackService _cashbackService;

        public BootstrapFacade(ISpotifyFactory factory, ICashbackService service)
        {
            _factory = factory;
            _cashbackService = service;
        }

        public void PrepareEnvironment()
        {
            // Inicializa tabela de cashback
            _cashbackService.InitializeCashbackDatabase();

            // incializa classe de serviços
            spotifyService = _factory.GetSpotifyService();

            // recupera valores do arquivo appsettings.json para requisitar token 
            tokenRequest = _factory.GetSpotifyTokenRequest();

            // recupera o token através da API do Spotify
            string access_token = spotifyService.GetToken(tokenRequest).Result;

            // obtém lista de álbuns da API do Spotify
            List<Album> list = spotifyService.GetAlbums(access_token);

            // incluir dados no BD
            spotifyService.AddAlbumsToDatabase(list);

        }
    }
}
