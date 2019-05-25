using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood
{
    public interface IIngredientFactory
    {
        MainCourse createMainCourse();
        Drink createDrink();
        Dessert createDessert();
    }

    public class MainCourse
    { }

    public class Drink
    { }


    public class Dessert
    { }


    public class FirstRestaurantIngredientFactory : IIngredientFactory
    {
        public Dessert createDessert()
        {
            Console.WriteLine("Create FirstRestaurant Dessert");
            return new Dessert();
        }

        public MainCourse createMainCourse()
        {
            Console.WriteLine("Create FirstRestaurant MainCourse");
            return new MainCourse();
        }

        public Drink createDrink()
        {
            Console.WriteLine("Create FirstRestaurant Drink");
            return new Drink();
        }

    }

    public class SecondRestaurantIngredientFactory : IIngredientFactory
    {
        public Dessert createDessert()
        {
            Console.WriteLine("Create SecondRestaurant Dessert");
            return new Dessert();
        }

        public MainCourse createMainCourse()
        {
            Console.WriteLine("Create SecondRestaurant MainCourse");
            return new MainCourse();
        }

        public Drink createDrink()
        {
            Console.WriteLine("Create SecondRestaurant Drink");
            return new Drink();
        }
    }
}
