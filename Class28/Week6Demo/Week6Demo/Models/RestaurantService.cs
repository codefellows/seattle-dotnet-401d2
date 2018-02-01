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
            return _context.Restaurant.FirstOrDefault(x => x.ID == id);
        }

        public Task<Restaurant> FindAsync(int id)
        {
            return _context.Restaurant.FirstOrDefaultAsync(x => x.ID == id);

        }


        public IQueryable<Restaurant> GetAll(int? count = null, int? page = null)
        {
            var actualCount = count.GetValueOrDefault(10);

            return _context.Restaurant
                    .Skip(actualCount * page.GetValueOrDefault(0))
                    .Take(actualCount);
        }

        public Task<Restaurant[]> GetAllAsync(int? count = null, int? page = null)
        {
            return GetAll(count, page).ToArrayAsync();
        }


        public async Task SaveAsync(Restaurant restaurant)
        {
            var doesItExist = restaurant.ID == default(int) ;

            _context.Entry(restaurant).State = doesItExist ? EntityState.Added : EntityState.Modified;

            await _context.SaveChangesAsync();
        }
    }
}
