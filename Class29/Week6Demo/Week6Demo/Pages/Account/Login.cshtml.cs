using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Week6Demo.Pages.Account
{
    
    public class LoginModel : PageModel
    {
        [BindProperty]
        [Required]
        [Display(Name ="Email Address")]
        public string EmailAddress { get; set; }

        [BindProperty]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public IActionResult OnPost()
        {
            var isValidUser = EmailAddress == "amanda@codefellows.com"  && Password == "Catz!";

            if(!isValidUser)
            {
                ModelState.AddModelError("", "Invalid Email or Password");
                return Page();
            }

            // Use Authentication
            var schem = CookieAuthenticationDefaults.AuthenticationScheme;

            // Adding the user's name to their claim within the Authentication Scheme
            var user = new ClaimsPrincipal(
                new ClaimsIdentity(
                    new[] { new Claim(ClaimTypes.Name, EmailAddress) }, schem
                    )
                );

            SignIn(user, schem);
            return RedirectToPage("/Index");


        }

        public async Task<IActionResult> OnPostLogout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            
            return RedirectToPage("/Index");
        }
    }
}