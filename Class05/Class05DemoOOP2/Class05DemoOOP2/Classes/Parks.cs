using System;
using System.Collections.Generic;
using System.Text;

namespace Class05DemoOOP2.Classes
{
   abstract class Parks
    {
        public string Name { get; set; }
        public int PersonMax { get; set; }
        public string Location { get; set; }
        public abstract int TicketPrice { get; set; }

        public void StartHiringProcess()
        {
            Console.WriteLine("Ariel is the hiring manager");
        }

        public void DetermineDailyEntertainment()
        {
            Console.WriteLine("Jeff is the entertainer");
        }

        //public abstract string FindEntranceLocations();

        public void DetermineSeasonsOpened()
        {
            Console.WriteLine("Dre only wants the parks open in the fall");
        }
    }
}
