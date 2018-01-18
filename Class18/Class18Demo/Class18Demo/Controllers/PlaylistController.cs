using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class18Demo.Data;
using Class18Demo.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Class18Demo.Controllers
{
    [Route("api/[controller]")]
    public class PlaylistController : Controller
    {
        private readonly MusicDbContext _context;

        public PlaylistController(MusicDbContext context)
        {
            _context = context;

        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Playlist> Get()
        {

            return _context.Playlists;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Playlist Get(int id)
        {
            Playlist pl = _context.Playlists.First(p => p.ID == id);
            pl.Songs = _context.Songs.Where(s => s.PlaylistID == id).ToList();


            //Query Songs Table to get all songs for playlist
           // Make the list of songs in PL == to result from the search
           // return back the playlist

            return pl ;
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
