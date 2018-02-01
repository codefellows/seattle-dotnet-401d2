using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Week6Demo.Models;

namespace Week6Demo.Pages.Admin
{
    public class AddEditRestaurantModel : PageModel
    {
        [FromRoute]
        public int? ID { get; set; }

        [BindProperty]
        public Restaurant Restaurant { get; set; }

        private readonly IRestaurantService restaurantService;

        public AddEditRestaurantModel(IRestaurantService rs)
        {
            restaurantService = rs;
        }
        public async Task OnGet()
        {
            Restaurant = await restaurantService.FindAsync(ID.GetValueOrDefault()) ?? new Restaurant();
        }

        public async Task<IActionResult> OnPost()
        {
            Restaurant rest = await restaurantService.FindAsync(ID.GetValueOrDefault()) ?? new Restaurant();
            rest.Name = Restaurant.Name;
            rest.Description = Restaurant.Description;
            rest.MenuItems = Restaurant.MenuItems;
            rest.StarRating = Restaurant.StarRating;

            await restaurantService.SaveAsync(rest);

            return RedirectToPage("/Restaurant", new { id = rest.ID });
        }

        public async Task<IActionResult> OnPostDelete()
        {
            await restaurantService.DeleteAsync(ID.Value);
            return RedirectToPage("/Index");

        }
    }
}