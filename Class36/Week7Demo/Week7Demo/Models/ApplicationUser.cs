using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Week7Demo.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime Birthday { get; set; }
        public int BadgeID { get; set; }
    }

    public static class ApplicationRoles
    {

        public const string Member = "Member";
        public const string Admin = "Admin";
        public const string CatLady = "CatLady";


    }
}
