using Class06Demo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class06Demo.Classes
{
    class Vehicle
    {
       static public void Drive(IDrive driver)
        {

            driver.StartCar();

        }
    }
}
