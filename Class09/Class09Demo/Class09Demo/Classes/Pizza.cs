using System;
using System.Collections.Generic;
using System.Text;

namespace Class09Demo.Classes
{
    abstract class Pizza
    {
        public List<string> Toppings { get; set; }
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public string Cheese { get; set; }
        public string Name { get; set; }
        public string CrustType { get; set; }



        public void Prepare()
        {
            Console.WriteLine("Prepare the Pizza");
        }

        public void Bake()
        {
            Console.WriteLine("Bake The pizza");
        }

        public void Cut()
        {
            Console.WriteLine("Cut the pizza");

        }

        public void Box()
        {
            Console.WriteLine("Box the pizza");

        }

    }
}
