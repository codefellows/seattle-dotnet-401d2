using System;
using System.Collections.Generic;
using System.Text;

namespace Class09Demo.Classes
{
    class CheesePizza: Pizza
    {
        public CheesePizza()
        {
            Name = "Cheese";
            Dough = "Gluten Free";
            CrustType = "Stuffed";
            Toppings.Add("Cheese");
            Toppings.Add("Extra Cheese");
        }
    }
}
