using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food
{
    public abstract class Strategy
    {
        public abstract void Cook(string food);
    }

    class RomanStylePizza : Strategy
    {
        public override void Cook(string name)
        {
            Console.WriteLine("Cooking " + name + " with  a soft crisp crust");
        }
    }

    class SeattleStylePizza : Strategy
    {
        public override void Cook(string name)
        {
            Console.WriteLine("Cooking " + name + " pizza with large hand-tossed thin crust");
        }
    }

}
