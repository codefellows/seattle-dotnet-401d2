using System;
using System.Collections.Generic;
using System.Linq;

namespace Class08Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<string> classList = new List<string>();

            classList.Add("Amanda");
            classList.Add("Luay");
            classList.Add("Jeff");
            classList.Add("Zach");
            classList.Add("Dustin");
            classList.Add("Dre");
            classList.Add("Ariel");


            //LINQ Query
            // Note the format
            IEnumerable<string> filteredNames = from n in classList
                                                where n.Contains("r")
                                                || n.Contains("a")                                                
                                                select n;

            IEnumerable<string> secondFilter = from n in filteredNames
                                               where n.Length > 5
                                               select n;

            foreach (string item in filteredNames)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("Line Break");
            foreach (string item in secondFilter)
            {
                Console.WriteLine(item);

            }

            string[] catNames = { "Josie", "Belle", "Leia", "Stitch", "Amber", "OctoCat"};

            //Anonymous type - with a LINQ query
            var filtered = from cat in catNames
                           where cat.Length > 4
                           select cat;
           
            Console.Clear();

            // Lambda expression (note the extension methods)
            var filterCats = catNames.Where(cat => cat.Length > 4)
                                     .FirstOrDefault(x => x.Contains("a"));
                                    


            Console.WriteLine("First Filter");
            foreach (var item in filtered)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Second Filter");


            foreach (var item in filterCats)
            {
                Console.WriteLine(item);
            }





        }
    }
}
