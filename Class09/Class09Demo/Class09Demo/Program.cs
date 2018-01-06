using Class09Demo.Classes;
using System;

namespace Class09Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("What Piza do you you want");

            string answer = Console.ReadLine();

            SimplePizzaFactory spf = new SimplePizzaFactory();

            Pizza pizza = spf.CreatePizza("Cheese");

            pizza.Prepare();
            pizza.Bake();
            pizza.Box();

            Zeeks zeeks = new Zeeks();
            zeeks.OrderPizza("Cheese");


        }
    }
}
