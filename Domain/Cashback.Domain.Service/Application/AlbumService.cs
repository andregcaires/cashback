using Cashback.Context.Interface;
using Cashback.Domain.Model;
using Cashback.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cashback.Service.Application
{
    public class AlbumService : IAlbumService
    {
        private IAlbumRepository _repo;

        public AlbumService(IAlbumRepository repo) => _repo = repo;

        public void Add()
        {
            
        }
    }
}
