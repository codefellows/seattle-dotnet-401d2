using System;
using System.Collections.Generic;
using System.Text;

namespace Class05DemoOOP2.Classes
{
    abstract class SixFlags : Amusement
    {
        public override sealed void EatAtConcessionStands()
        {
            base.EatAtConcessionStands();
        }

        public virtual bool DetermineSupermanAvailable()
        {
            return true;
        }

        public virtual sealed void PlayAGame();



    }
}
