using System;
using System.Collections.Generic;
using System.Text;

namespace Class06Demo.Classes
{
   abstract class Robot
    {
        public void Speech()
        {
            Console.WriteLine("Take over the world!");
        }

        public string Color { get; set; }
    }
}
