using Class06Demo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class06Demo.Classes
{
    class Wizard : Person, IDrive, IStudent
    {
        public void DrinkCoffee()
        {
            Console.WriteLine("Accio Coffee!");
        }

        public void Eat()
        {
            Console.WriteLine("Butterbeer and Chocolate Frogs for all!");
        }

        public bool License()
        {
            Console.WriteLine("I have a license");
            return true;
        }

        public void ShiftGears()
        {
            Console.WriteLine("Shifting all the gears");
        }

        public void Sleep()
        {
            Console.WriteLine("To the Slytherin Dorm Room!");
        }

        public void StartCar()
        {
            Console.WriteLine("Vroom Vroom");
        }

        public void StopCar()
        {
            Console.WriteLine("Stop!!");
        }
    }
}
