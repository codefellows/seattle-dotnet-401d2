using Class06Demo.Classes;
using Class06Demo.Interfaces;
using System;

namespace Class06Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Wizard harry = new Wizard();
            Vehicle.Drive(harry);

            Wally wally = new Wally();

            Vehicle.Drive(wally);

            HouseElf dobby = new HouseElf();

            Vehicle.Drive(dobby);

            IDrive myCar = wally; 

            if(dobby is IDrive)
            {

            }

        }
    }
}
