using Cashback.Spotify;
using Cashback.Spotify.Factory;
using Cashback.Spotify.Interface;
using Cashback.Spotify.Service;
using Cashback.Spotify.Token;
using Microsoft.Extensions.DependencyInjection;

namespace Cashback.DI
{
    /// <summary>
    /// Realiza a injeção de dependência, abstraindo as referências entre projetos
    /// </summary>
    public static class DependencyInjection
    {
        /// <summary>
        /// Registra os serviços no container de Injeção de Dependência
        /// </summary>
        /// <param name="services">Coleção de serviços configurada na classe Startup</param>
        public static void RegisterServices(IServiceCollection services)
        {
            // Spotify
            services.AddSingleton<ISpotifyFacade, SpotifyFacade>();
            services.AddSingleton<ISpotifyFactory, SpotifyFactory>();
            services.AddSingleton<ISpotifyService, SpotifyService>();
            services.AddSingleton<ISpotifyTokenRequest, SpotifyTokenRequest>();
        }
    }
}
