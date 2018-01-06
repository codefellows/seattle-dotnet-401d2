using System;
using System.Collections.Generic;
using System.Text;

namespace Class09Demo.Classes
{
    class Zeeks : PizzaStore
    {
        protected override Pizza CreatePizza(string pizzaType)
        {

            SimplePizzaFactory pf = new SimplePizzaFactory();
            Console.WriteLine("Welcome to Zeeks Pizza");
            return pf.CreatePizza(pizzaType);
        }
    }
}
