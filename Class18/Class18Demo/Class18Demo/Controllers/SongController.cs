using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Class18Demo.Data;
using Class18Demo.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Class18Demo.Controllers
{
    [Route("api/[controller]")]
    public class SongController : Controller
    {
        private readonly MusicDbContext _context;

        public SongController(MusicDbContext context)
        {
            _context = context;
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Song> Get()
        {
            return _context.Songs;

        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Song Get(int id)
        {
            var result = _context.Songs.FirstOrDefault(x => x.ID == id);
            return result;
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Song value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _context.Songs.AddAsync(value);
            await _context.SaveChangesAsync();
            return CreatedAtAction("Get", value);
        }

        // PUT api/<controller>/5
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Put(int id, [FromBody]Song value)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //check id exists in the database
            var result = _context.Songs.FirstOrDefault(x => x.ID == id);
            if(result != null)
            {
                //result.ID = id;
                result.Name = value.Name;
                result.Album = value.Album;
                result.Artist = value.Artist;
               _context.Update(result);
               await _context.SaveChangesAsync();
            }
            else
            {
                await Post(value);
            }

            return Ok(); 
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {

            var result = _context.Songs.FirstOrDefault(x => x.ID == id);

            if (result != null)
            {
                _context.Remove(result);
                await _context.SaveChangesAsync();
                return Ok();
            }
            
            return BadRequest();

          


        }
    }
}
