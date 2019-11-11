using Cashback.Context;
using Cashback.Context.Commom;
using Cashback.Context.Interface;
using Cashback.Context.Repository;
using Cashback.DI.Interface;
using Cashback.Service.Application;
using Cashback.Service.Interface;
using Cashback.Spotify;
using Cashback.Spotify.Factory;
using Cashback.Spotify.Interface;
using Cashback.Spotify.Service;
using Cashback.Spotify.Token;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

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
            // Context
            services.AddDbContext<DatabaseContext>(options => options
                .UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Database\\Cashback.mdf;Integrated Security=True;Connect Timeout=30"), 
                ServiceLifetime.Scoped);

            // Bootstrap
            services.AddScoped<IBootstrapFacade, BootstrapFacade>();

            // Spotify
            services.AddScoped<ISpotifyTokenRequest, SpotifyTokenRequest>();
            services.AddScoped<ISpotifyFactory, SpotifyFactory>();
            services.AddScoped<ISpotifyService, SpotifyService>();

            // Repository
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IAlbumRepository, AlbumRepository>();
            services.AddScoped<ICashbackRepository, CashbackRepository>();
            services.AddScoped<ISaleRepository, SaleRepository>();

            // Service
            services.AddScoped<IAlbumService, AlbumService>();
            services.AddScoped<ICashbackService, CashbackService>();
            services.AddScoped<ISaleService, SaleService>();


        }
    }
}
