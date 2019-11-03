using Cashback.Spotify.Interface;
using Cashback.Spotify.Model;
using Cashback.Spotify.Token;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using System.Net.Http.Headers;
using Cashback.Spotify.Enums;
using System;

namespace Cashback.Spotify.Service
{
    public class SpotifyService : ISpotifyService
    {
        private IConfiguration _config;
        private SpotifyTokenResponse resp;

        public SpotifyService(IConfiguration config)
        {
            _config = config;
        }

        public IEnumerable<SpotifyAlbumResponse> GetAlbums(string access_token)
        {
            StringBuilder sb;
            List<SpotifyAlbumResponse> list = new List<SpotifyAlbumResponse>();
            try
            {
                using (var http = new HttpClient())
                {
                    http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", access_token);

                    foreach (var styleName in Enum.GetValues(typeof(AlbumStyles)))
                    {
                        sb = new StringBuilder(_config["Spotify:SearchURI"]);
                        sb.Append($"?q={styleName}");
                        sb.Append("&type=album");
                        sb.Append("&limit=50");

                        var request = http.GetAsync(sb.ToString()).Result;
                        var response = request.Content.ReadAsStringAsync();

                        if (response.IsCompleted)
                        {
                            list.Add(response.Result.JsonToObject<SpotifyAlbumResponse>());
                        }
                    }
                    return list;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

        }

        public async Task<string> GetToken(ISpotifyTokenRequest req)
        {
            try
            {
                string access_token = "";
                using (var http = new HttpClient())
                {

                    http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", req.ToAuthorization());

                    Dictionary<string, string> dict = new Dictionary<string, string>();
                    dict.Add("grant_type", req.GetGrantType());

                    FormUrlEncodedContent content = new FormUrlEncodedContent(dict);

                    HttpResponseMessage request = await http.PostAsync(_config["Spotify:TokenURI"], content);
                    var response = request.Content.ReadAsStringAsync();

                    if (response.IsCompleted)
                    {
                        resp = response.Result.JsonToObject<SpotifyTokenResponse>();
                        access_token = resp.access_token;
                    }

                    return access_token;
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

        }
    }
}