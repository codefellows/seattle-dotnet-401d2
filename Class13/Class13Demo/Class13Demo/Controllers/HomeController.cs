using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class13Demo.Data;
using Class13Demo.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Class13Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly CatFarmDbContext _context;

        public HomeController(CatFarmDbContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            //Query a database table
            var connection = _context.CatFarm;
            CatFarm cf = new CatFarm();
            cf.Name = "Amandas Cat Farm";
            cf.NumberOfCats = 100;
            cf.Location = "Cat Island";

            _context.CatFarm.Add(cf);
            _context.SaveChanges();


            //LINQ/Lambda query against a database

         var x = _context.CatFarm.Where(c => c.ID == 1);
            return View();
        }
    }
}
