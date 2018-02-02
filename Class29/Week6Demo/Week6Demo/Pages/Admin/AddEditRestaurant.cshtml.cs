using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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


        [BindProperty]
        public IFormFile Image { get; set; }

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

            if (Image != null)
            {
                // Open the memory stream to start the conversion
                using (var stream = new System.IO.MemoryStream())
                {
                    //Make sure to copy the image to the stream
                    await Image.CopyToAsync(stream);

                    //Convert the image from stream to an array and set to new Restaurant Object image property
                    rest.Image = stream.ToArray();
                    //Set the content type for the Restaurant object
                    rest.ImageContentType = Image.ContentType;
                }
            }

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