using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood
{
   public interface IRestaurantNetwork
    {
        FirstRestaurantStore GetFirstRestaurantStore();
        SecondRestaurantStore GetSecondRestaurantStore();
    }

    public class RestaurantNetwork : IRestaurantNetwork
    {
        public SecondRestaurantStore GetSecondRestaurantStore() => new SecondRestaurantStore();
    }
}
