using Class06Demo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class06Demo.Classes
{
    class Day6 : IExample, ICat
    {
        public int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void CatPlay()
        {
            throw new NotImplementedException();
        }

        public void ThisIsAnExample()
        {
           //Put Code here
        }
    }
}
