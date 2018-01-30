using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week6Demo.Models
{
    interface IRestaurantService
    {
        Task DeleteAsync(int id);

        Restaurant Find(int id);

        Task<Restaurant> FindAsync();

        IQueryable<Restaurant> GetAll(int? count = null, int? page = null);
        Task<Restaurant[]> GetAllAsync(int? count = null, int? page = null);
        Task SaveAsync(Restaurant restaurant);

    }
}
