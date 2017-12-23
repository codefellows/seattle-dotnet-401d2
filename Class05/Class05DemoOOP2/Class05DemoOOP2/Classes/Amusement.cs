using System;
using System.Collections.Generic;
using System.Text;

namespace Class05DemoOOP2.Classes
{
    internal abstract class Amusement : Parks
    {
        public override int TicketPrice { get; set; }

        //public override string FindEntranceLocations()
        //{
        //    Console.WriteLine("Luay requires a password");
        //    return "Luay requires a password";
        //}

        private void RideARollerCoasters()
        {

        }

        public virtual void EatAtConcessionStands()
        {
            Console.WriteLine("Eat the funnel cakes!!");
        }

       
    }
}
