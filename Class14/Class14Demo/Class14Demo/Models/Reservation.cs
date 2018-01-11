using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class14Demo.Models
{
    public class Reservation
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Time { get; set; }
        public int PartySize { get; set; }
    }
}
