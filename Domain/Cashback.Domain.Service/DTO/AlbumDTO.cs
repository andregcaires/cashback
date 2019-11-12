using System;
using System.Collections.Generic;
using System.Text;

namespace Cashback.Service.DTO
{
    /// <summary>
    /// Representa objeto a ser obtido via POST no controller de Album
    /// </summary>
    public class AlbumDTO
    {
        public int ID { get; set; }
        public int Quantity { get; set; }
    }
}
