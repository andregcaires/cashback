using Cashback.Spotify.Interface;

namespace Cashback.Spotify.Factory
{
    public class SpotifyFactory : ISpotifyFactory
    {
        private ISpotifyTokenRequest _tokenRequest;
        private ISpotifyService _service;
        public SpotifyFactory(ISpotifyTokenRequest tokenRequest, ISpotifyService service)
        {
            _tokenRequest = tokenRequest;
            _service = service;
        }

        public ISpotifyTokenRequest GetSpotifyTokenRequest()
        {
            return this._tokenRequest;
        }

        public ISpotifyService GetSpotifyService()
        {
            return this._service;
        }
    }
}
