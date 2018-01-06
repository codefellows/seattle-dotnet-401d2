using System;
using System.Collections.Generic;
using System.Text;

namespace Class09Demo.Classes
{
    class SimplePizzaFactory
    {
        public Pizza CreatePizza(string name)
        {
            Pizza pizza = null;
            

            if (name == "Cheese")
            {
                pizza = new CheesePizza();

            }
            else if (name == "Pepperoni")
            {
                pizza = new PepperoniPizza();
            }
            else if (name == "Hawaiian")
            {
                pizza = new PepperoniPizza();
            }

            return pizza;
        }

    }
}
