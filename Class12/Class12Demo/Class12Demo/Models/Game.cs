using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class12Demo.Models
{
    public class Game
    {
        public string Name { get; set; }
        public int Number { get; set; }

        public int GetRandomNumber()
        {
            Random random = new Random();
            Number = random.Next(0, 6);
            return Number;
        }
    }

}
