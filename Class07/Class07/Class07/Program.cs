using Class07.Classes;
using System;
using System.Collections.Generic;

namespace Class07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car car = new Car();
            car.CarColor = Car.Color.Red;
            int carColor = (int)car.CarColor;

            List<string> myList = new List<string> {"Amanda","JosieCat","Belle Kitty" };

            LinkedList<string> myStringLL = new LinkedList<string>();
            myStringLL.add
       

            foreach (string item in myList)
            {
                Console.WriteLine(item);

            }

            myList.Add("Dre");
            myList.Add("Matt");
            myList.Add("Luay");

            Console.WriteLine("New Items have been added. outputting full list now..");

            foreach (string i in myList)
            {
                Console.WriteLine(i);

            }

            myList.Remove("Belle Kitty");

            foreach (string i in myList)
            {
                Console.WriteLine(i);

            }

            myList.Remove(myList[0]);

            foreach (string i in myList)
            {
                Console.WriteLine(i);

            }

            myList.Sort();
           
            Console.WriteLine();


            foreach (string i in myList)
            {
                Console.WriteLine(i);

            }

            Car car1 = new Car();
            car1.Name = "Lightning McQueen";

            List<Car> myCars = new List<Car> { new Car { Name = "Sally", CarColor = Car.Color.Red }, new Car { CarColor = Car.Color.Purple, Name = "Mater" } };
            myCars.Add(car1);

            foreach (Car item in myCars)
            {
                Console.WriteLine(item.Name);
            }

            Garage<Car> myGarage = new Garage<Car>();

            Car car2 = new Car();
            car2.Name = "Murphy";

            Car car3 = new Car();
            car3.Name = "Kitt";


            myGarage.Add(car1);
            myGarage.Add(car2);
            myGarage.Add(car3);

            Console.Clear();
            Console.WriteLine("Our Garage is full of Cars");

           

            foreach (Car item in myGarage)
            {
                Console.WriteLine(item.Name);

            }


        }
    }
}
