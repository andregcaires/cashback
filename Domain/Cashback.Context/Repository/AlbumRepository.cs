using Cashback.Context.Commom;
using Cashback.Context.Interface;
using Cashback.Domain.Model;

namespace Cashback.Context.Repository
{
    public class AlbumRepository : Repository<Album>, IAlbumRepository
    {
        private delegate bool Condition(Album album);

        public AlbumRepository(DatabaseContext context) : base(context)
        {
        }

    }
}
