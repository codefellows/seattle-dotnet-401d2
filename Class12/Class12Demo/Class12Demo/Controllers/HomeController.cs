using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class12Demo.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Class12Demo.Controllers
{

    public class HomeController : Controller
    {
        // GET: /<controller>/

        //HTTPGET "Gets" the controller on load
        [HttpGet]
        public IActionResult Index()
        {
            Game g = new Game();
            g.Name = "Amandas Game";
            g.GetRandomNumber();

            Game r = new Game();
            r.Name = "Luays Game";
            r.GetRandomNumber();

            Game s = new Game();
            s.Name = "Dustins Game";
            s.GetRandomNumber();

            //List<string> list = new List<string>();
            //list.Add("Cats");
            //list.Add("Dogs");
            //list.Add("Goats");
            //list.Add("Chickens");
            //list.Add("Rabbits");

            //List<Game> games = new List<Game>();
            //games.Add(g);
            //games.Add(r);
            //games.Add(s);

            ViewData["Name"] = "Amanda";

            // Return the Game object over to the View
            // This is located in the Views/Home/Index.cshtml file
            return View(r);
        }

        //After posting the form from the Index.cshtml, this gets
        // called and brings in the correct parameters through model binding.
        [HttpPost]
        public IActionResult Index(string name, string cats)
        {
            // Redirect to the Winner Action within the same Controller
            // Sending the name and cats to the Winner Action
            return RedirectToAction("Winner", new {name, cats });

        }

        public IActionResult Winner(string name, string cats)
        {
            
            List<string> list = new List<string>();
            list.Add(name);
            list.Add(cats);

            //send the list to the View
            // this view is located in the Views/Home/Winner.cshtml file
            return View(list); ;
        }
    }
}
