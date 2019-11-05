using System;
using System.Collections.Generic;
using System.Text;

namespace Cashback.Domain.Model
{
    public class Album : Entity
    {
        public string Name { get; set; }
        public MusicStyle MusicStyle { get; set; }

        private decimal price;
        public decimal Price { get {
                return this.price;
            }
            set {
                this.price = GeneratePrice();
            }
        }

        private decimal GeneratePrice()
        {
            Random rand = new Random();
            return decimal.Parse($"{rand.Next(1, 50)},{rand.Next(00, 99)}");
        }

    }
}
