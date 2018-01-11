using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class14Demo.Data;
using Class14Demo.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Class14Demo.Controllers
{
    public class HomeController : Controller
    {
        private RestaurantDbContext _context;

        public HomeController(RestaurantDbContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Reservation reservation)
        {
            //add ind. reservation to the database
            _context.Reservations.Add(reservation);
            //Saving the entry
            _context.SaveChanges();

            //Redirect to details action
            return RedirectToAction("Details");
        }

        public IActionResult Details()
        {
            //Get All Reservations from the Database
            IEnumerable<Reservation> myRezzies = _context.Reservations;
            return View(myRezzies);
        }

        [HttpGet]
        //Bring in Id of reservation
        // send reservation back to view from DB
        public IActionResult Update(int id)
        {
            return View(_context.Reservations.FirstOrDefault(r => r.ID == id));
        }

        [HttpPost]
        public IActionResult Update(Reservation r)
        {
            _context.Update(r);
            _context.SaveChanges();
            return RedirectToAction("Details");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
           return View(_context.Reservations.First(x => x.ID == id));
        }

        [HttpPost]
        public IActionResult Delete(Reservation r)
        {
            _context.Remove(r);
            _context.SaveChanges();
            return RedirectToAction("Details");
        }

    }
}
