using System;
using System.Collections.Generic;
using System.Text;

namespace Cashback.Domain.Model
{
    public class Album : Entity
    {
        public string Name { get; set; }
        public string MusicStyle { get; set; }

        private decimal price;
        public decimal Price { get {
                return this.price;
            }
            set {
                this.price = GeneratePrice();
            }
        }

        public static decimal GeneratePrice()
        {
            Random rand = new Random();
            return decimal.Parse($"{rand.Next(1, 50)},{rand.Next(00, 99)}");
        }

        public static IEnumerable<Album> New(List<string> names, string musicStyle)
        {
            foreach(string name in names)
            {
                yield return new Album()
                {
                    Name = name,
                    MusicStyle = musicStyle, 
                    Price = GeneratePrice()
                };
            }

        }

    }
}
