using Cashback.Domain.Enums;
using Cashback.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cashback.Service.Tests.Mock
{
    public static class DataMock
    {
        public static IEnumerable<Album> GenerateAlbums()
        {
            Random random = new Random();

            for (int i = 0; i < 100; i++)
                yield return Album.New(i.ToString(), Enum.GetName(typeof(AlbumStyles), random.Next(0, 4)));
            
        }
    }
}
