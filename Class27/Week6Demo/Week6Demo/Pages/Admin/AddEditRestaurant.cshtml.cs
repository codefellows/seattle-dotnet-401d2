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
        public AddEditRestaurantModel(IRestaurantService )
        {

        }
        public void OnGet()
        {

        }
    }
}