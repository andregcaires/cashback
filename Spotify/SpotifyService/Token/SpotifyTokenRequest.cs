using Cashback.Spotify.Interface;
using Microsoft.Extensions.Configuration;
using System;
using System.Text;

namespace Cashback.Spotify.Token
{
    public class SpotifyTokenRequest : ISpotifyTokenRequest
    {
        public string client_id { get; set; }
        public string response_type { get; set; }
        public string redirect_uri { get; set; }
        public string client_secret { get; set; }
        public string grant_type { get; set; }

        /// <summary>
        /// Recupera dados do arquivo appsettings.json
        /// </summary>
        /// <param name="config">IConfiguration por DI</param>
        public SpotifyTokenRequest(IConfiguration config)
        {
            client_id = config["Spotify:ClientID"];
            response_type = config["Spotify:ResponseType"];
            redirect_uri = config["Spotify:RedirectURL"];
            client_secret = config["Spotify:ClientSecret"];
            grant_type = config["Spotify:GrantType"];
        }

        public string ToAuthorization() => Convert.ToBase64String(Encoding.UTF8.GetBytes($"{this.client_id}:{this.client_secret}"));

        public string GetGrantType() => this.grant_type;

    }
}