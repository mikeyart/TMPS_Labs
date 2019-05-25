using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            var FirstRestaurantStore = Franchise.Instance.RestaurantNetwork.GetFirstRestaurantStore();
            var SecondRestaurantStore = Franchise.Instance.RestaurantNetwork.GetSecondRestaurantStore();
            Console.WriteLine("--------------------------------------------");
            var a = FirstRestaurantStore.OrderMenu("Menu NR.1");
            Console.WriteLine("--------------------------------------------");
            var b = SecondRestaurantStore.OrderMenu("Menu NR.2");
            Console.WriteLine("--------------------------------------------");
            var c = FirstRestaurantStore.OrderMenu("Menu NR. 2");

            var clonedMenuList = new List<Menu>()
            {
                a.Clone(),
                b.Clone(),
                c.Clone()
            };

            foreach (var menu in clonedMenuList)
                Console.WriteLine(menu.GetName());

            Console.ReadKey();
        }
    }
}
