using Class05DemoOOP2.Classes;
using System;

namespace Class05DemoOOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MagicMountain mm = new MagicMountain();

            Water water = new Water();

         

           
        }

        static void AccessModifiers()
        {
            // Public - Anyone and everyone can access 
            // Private - Accessible only to that class
            // Protected - The class and it's derived classes have access
            // Internal - accessible inside the assembly. 
            // Protected Internal - accessible from current asebmly or from types that are derived from containing classes
        }
    }
}
