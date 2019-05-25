using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood
{
    class MenuNr1 : Menu
    {
        IIngredientFactory ingredientFactory;

        public MenuNr1(IIngredientFactory _ingredientFactory)
        {
            ingredientFactory = _ingredientFactory;
            name = "Specialty";
            Drink = "Coca-Cola";
            Dessert = "Tiramisu";
            toppings.Add("Chocolate");

        }

        public override void TakeOrder()
        {
            Console.WriteLine("Approaching the customers and take order");
            ingredientFactory.createMainCourse();
            ingredientFactory.createDrink();
            ingredientFactory.createDessert();
        }

        public override Menu Clone()
        {
            Console.WriteLine("-----------CLONE MENU-----------");
            return this.MemberwiseClone() as Menu;
        } 
    }

    class MenuNr2 : Menu
    {
        IIngredientFactory ingredientFactory;

        public MenuNr2(IIngredientFactory _ingredientFactory)
        {
            ingredientFactory = _ingredientFactory;
            name = "Second Menu";
            Drink = "Fanta";
            Dessert = "CheeseCake";
            toppings.Add("Cherry");

        }

        public override void TakeOrder()
        {
            Console.WriteLine("Approaching the customers and take order");
            ingredientFactory.createMainCourse();
            ingredientFactory.createDrink();
            ingredientFactory.createDessert();
        }

        public override Menu Clone()
        {
            Console.WriteLine("-----------CLONE MENU-----------");
            return this.MemberwiseClone() as Menu;
        }


    }

    class MenuNr3 : Menu
    {
        IIngredientFactory ingredientFactory;

        public MenuNr3(IIngredientFactory _ingredientFactory)
        {
            ingredientFactory = _ingredientFactory;
            name = "Third Menu";
            Drink = "Sprite";
            Dessert = "CheeseCake";
            toppings.Add("CBlueberry");

        }

        public override void TakeOrder()
        {
            Console.WriteLine("Approaching the customers and take order");
            ingredientFactory.createMainCourse();
            ingredientFactory.createDrink();
            ingredientFactory.createDessert();
        }

        public override Menu Clone()
        {
            Console.WriteLine("-----------CLONE MENU-----------");
            return this.MemberwiseClone() as Menu;
        }


    }
}
