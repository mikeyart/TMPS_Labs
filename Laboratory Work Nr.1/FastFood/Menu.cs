using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood
{
    public abstract class Menu
    {
        public String name;
        public String MainCourse;
        public String Drink;
        public String Dessert;
        public ArrayList toppings = new ArrayList();

        public abstract void TakeOrder();

        public virtual void Prepare()
        {
            Console.WriteLine("Prepared in the kitchen by cooks");
        }

        public virtual void Deliver()
        {
            Console.WriteLine("Delivered to the customer by the waiter");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place leftovers in box");
        }

        public string GetName()
        {
            return name;
        }

        public abstract Menu Clone();
    }
}
