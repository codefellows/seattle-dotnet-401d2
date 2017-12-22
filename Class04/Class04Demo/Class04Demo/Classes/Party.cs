using System;
using System.Collections.Generic;
using System.Text;

namespace Class04Demo
{
   public abstract class Party
    {
        public int NumberOfPeople { get; set; }
        
        public int Budget { get; set; }

        public string Location { get; set; }
        public string Entertainment { get; set; }

        public string Menu { get; set; }


        public void IDance()
        {
            Console.WriteLine("Luay Dances");
        }

        public void MeetPeople()
        {
            Console.WriteLine("Dre Mingles");
        }

        public void Indulge()
        {
            Console.WriteLine("Matt likes the refreshments and buffet tables");
        }




    }
}
