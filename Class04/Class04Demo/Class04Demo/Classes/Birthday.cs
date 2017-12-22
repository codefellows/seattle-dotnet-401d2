using System;
using System.Collections.Generic;
using System.Text;

namespace Class04Demo.Classes
{
    abstract class Birthday : Party
    {
        public bool Decorations { get; set; }
        public string ClownName { get; set; }
        public int NumberOfPresents { get; set; }

        public void SingBirthdaySong()
        {
            Console.WriteLine("Jeff Sings beautifully to the birthday person");

        }

        public void EatCake()
        {
            Console.WriteLine(" Zach says the cake is a lie");
        }

        
        public void PlayGames()
        {
            Console.WriteLine("Ariel wins at Musical Chairs");
        }


    }
}
