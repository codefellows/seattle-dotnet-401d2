using System;
using System.Collections.Generic;
using System.Text;

namespace Class09Demo.Classes
{
    class ZeeksFactory
    {
       public static Pizza CreatePizza(string pizzaType)
        {
            Pizza pizza = null;

            switch (pizzaType)
            {
                case "Hawaiian":
                    pizza = new HawaiianPizza();
                    break;
                case "Cheese":
                    pizza = new CheesePizza();
                    break;
                default:
                    break;
            }

            return pizza;
        }
    }
}
