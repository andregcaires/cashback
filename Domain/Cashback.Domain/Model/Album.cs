﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cashback.Domain.Model
{
    public class Album : Entity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public MusicStyle MusicStyle { get; set; }
    }
}
