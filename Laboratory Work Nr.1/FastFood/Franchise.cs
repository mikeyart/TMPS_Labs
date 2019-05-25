using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood
{
    public sealed class Franchise
    {
        private Franchise()
        { }

        public static Franchise Instance { get; } = new Franchise();

        public IRestaurantNetwork RestaurantNetwork { get; } = new RestaurantNetwork(); 
    }
}
