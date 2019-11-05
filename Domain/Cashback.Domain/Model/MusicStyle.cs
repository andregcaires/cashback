using System;
using System.Collections.Generic;
using System.Text;

namespace Cashback.Domain.Model
{
    public class MusicStyle : Entity
    {
        public string Name { get; set; }

        public virtual List<Album> Albums { get; set; }
    }
}
