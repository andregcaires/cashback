using Cashback.Context.Interface;
using Cashback.Domain.Model;
using Cashback.Service.Interface;
using Utilities;
using System.Collections.Generic;
using System.Linq;
using System;

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

        public IList<Album> GetPaged(int skip, int pageSize, string musicStyle = "")
        {
            var condition = !string.IsNullOrWhiteSpace(musicStyle)
                    ? new Func<Album, bool>(x => x.MusicStyle == musicStyle)
                    : new Func<Album, bool>(x => true);

            return _repo
                .GetAllAsQueryable()
                .Where(condition)
                .GetPaged(skip, pageSize)
                .Results;
        }

        public void AddAlbumsToDatabase(List<Album> albumList)
        {
            if (_repo.GetAllAsList().Count == 0)
                albumList.ForEach(x => _repo.Insert(x));
        }

        public Album FindById(int id)
        {
            return _repo.GetById(id);
        }
    }
}
