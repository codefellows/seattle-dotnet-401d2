using System;
using System.Collections.Generic;
using System.Text;

namespace Class04Demo
{
   public class AmandasClass
    {
        //public AmandasClass()
        //{

        //}

        public AmandasClass(string name, int age)
        {
            Name = name;

        }

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public int NumberOfCats { get; set; } = 10;
        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                if(value == null)
                {
                    value = "Amanda";
                }
            }

        }

    }
}
