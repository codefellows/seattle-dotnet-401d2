using Class06Demo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class06Demo.Classes
{
    class Wally : Robot, IDrive
    {
        public bool License()
        {
            throw new NotImplementedException();
        }

        public void ShiftGears()
        {
            throw new NotImplementedException();
        }

        public void StartCar()
        {
            throw new NotImplementedException();
        }

        public void StopCar()
        {
            throw new NotImplementedException();
        }

        void CompactGarbage()
        {
            Console.WriteLine("Wall-e");
        }
    }
}
