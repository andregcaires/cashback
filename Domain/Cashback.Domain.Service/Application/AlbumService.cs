using Cashback.Context.Interface;
using Cashback.Domain.Model;
using Cashback.Service.Interface;
using Utilities;
using System.Collections.Generic;
using System.Text;

namespace Cashback.Service.Application
{
    public class AlbumService : IAlbumService
    {
        private IAlbumRepository _repo;

        public AlbumService(IAlbumRepository repo) => _repo = repo;

        public void Add(Album item)
        {
            _repo.Insert(item);
        }

        public List<Album> SelectAll()
        {
            return _repo.GetAllAsList();
        }

        public IList<Album> GetPaged(int skip, int pageSize)
        {
            return _repo.GetAllAsQueryable()
                .GetPaged(skip, pageSize)
                .Results;
        }

        public void AddAlbumsToDatabase(List<Album> albumList)
        {
            foreach (Album item in albumList)
            {
                _repo.Insert(item);
            }
        }
    }
}
