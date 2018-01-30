using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week6Demo.Data;

namespace Week6Demo.Models
{
    public class RestaurantService : IRestaurantService
    {
        private readonly RestaurantDbContext _context;


        public RestaurantService()
        {
            var options = new DbContextOptionsBuilder<RestaurantDbContext>()
                .UseInMemoryDatabase("MyRestaurantFinder")
                .Options;
            _context = new RestaurantDbContext(options);
                
        }
        public RestaurantService(RestaurantDbContext context)
        {
            _context = context;
        }
        public async Task DeleteAsync(int id)
        {
            _context.Restaurant.Remove(new Restaurant { ID = id });
            await _context.SaveChangesAsync();
        }

        public Restaurant Find(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Restaurant> FindAsync()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Restaurant> GetAll(int? count = null, int? page = null)
        {
            throw new NotImplementedException();
        }

        public Task<Restaurant[]> GetAllAsync(int? count = null, int? page = null)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }
    }
}
