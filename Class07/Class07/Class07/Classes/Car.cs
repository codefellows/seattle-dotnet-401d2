using System;
using System.Collections.Generic;
using System.Text;

namespace Class07
{
    class Car
    {
        public Color CarColor { get; set; }
        public string Name { get; set; }
        public enum Color : int
        {
            Red= 1,
            Blue,
            Green, 
            Purple,
        }
    }
}
