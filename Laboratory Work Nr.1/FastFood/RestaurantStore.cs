using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood
{
    public abstract class RestaurantStore
    {

        public Menu OrderMenu(String type)
        {
            var menu = CreateMenu(type);
            menu.Prepare();
            menu.Deliver();
            menu.Box();
            return menu;
        }

        //It has the responsibility for creating the pizza
        protected abstract Menu CreateMenu(String type);
    }

    public class FirstRestaurantStoreStore : RestaurantStore
    {
        protected override Menu CreateMenu(string type)
        {
           Menu menu = null;
            IIngredientFactory ingredientFactory = new FirstRestaurantIngredientFactory();

            if (type == "Drink")
                menu = new MenuNr2(ingredientFactory);
            else if (type == "Fanta")
               menu = new MenuNr1(ingredientFactory);

            return menu;
        }
    }

    public class SecondRestaurantStoreStore : RestaurantStore
    {
        protected override Menu CreateMenu(string type)
        {
            Menu menu= null;
            IIngredientFactory ingredientFactory = new SecondRestaurantIngredientFactory();

            if (type == "Neapolitana")
               menu = new MenuNr2(ingredientFactory);

            return menu;
        }


    }
}
