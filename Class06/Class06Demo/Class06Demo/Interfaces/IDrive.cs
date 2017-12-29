using System;
using System.Collections.Generic;
using System.Text;

namespace Class06Demo.Interfaces
{
    interface IDrive
    {
        bool License();
        void StartCar();
        void StopCar();
        void ShiftGears();
    }
}
