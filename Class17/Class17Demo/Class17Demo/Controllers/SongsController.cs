using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class17Demo.Data;
using Class17Demo.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Class17Demo.Controllers
{
    [Route("api/[controller]")]
    public class SongsController : Controller
    {
        private readonly MusicDbContext _context;

        public SongsController(MusicDbContext context)
        {
            _context = context;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Song> Get()
        {
            return _context.JammieJams;
     
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Song Get(int id)
        {
            var result = _context.JammieJams.FirstOrDefault(s => s.ID == id);
            return result;
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Song value)
        {
            await _context.JammieJams.AddAsync(value);
            await _context.SaveChangesAsync();
            return CreatedAtAction("Get", new { value.ID }, value);
        }

        // PUT api/<controller>/5
        [HttpPut("{id:int}")]
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
