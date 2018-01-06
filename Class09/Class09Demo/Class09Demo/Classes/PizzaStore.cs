using System;
using System.Collections.Generic;
using System.Text;

namespace Class09Demo.Classes
{
    abstract class PizzaStore
    {
        SimplePizzaFactory Factory { get; set; }

        //public PizzaStore(SimplePizzaFactory factory)
        //{
        //    this.Factory = factory;
        //}

        

        //This is called a factory method. This is what actually does the creation. 
        protected abstract Pizza CreatePizza(string pizzaType);

        public Pizza OrderPizza(string pizzaType)
        {
            Pizza pizza = null;

      
            pizza = Factory.CreatePizza(pizzaType);
            pizza.Bake();
            pizza.Prepare();
            pizza.Box();

            return pizza;
        }

    }
}
