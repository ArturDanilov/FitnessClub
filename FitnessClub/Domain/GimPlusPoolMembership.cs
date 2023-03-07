using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessClub.Domain
{
    internal class GimPlusPoolMembership : IMembership
    {
        private readonly string _name;
        private readonly decimal _price;

        public GimPlusPoolMembership(decimal price)
        {
            _name = "Gym plus pool membership";
            _price = price;
        }
        public string Name => _name;
        public string Description { get; set; }
        public decimal GetPrice() => _price;
    }
}
