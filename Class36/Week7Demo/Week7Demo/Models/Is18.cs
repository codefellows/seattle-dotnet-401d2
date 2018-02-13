using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Week7Demo.Models
{
    public class Is18 : AuthorizationHandler<MinimumAgeRequirement>
    {
        private const int minAge = 18;
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, MinimumAgeRequirement requirement)
        {
            if (!context.User.HasClaim(c => c.Type == ClaimTypes.DateOfBirth))
            {
                return Task.CompletedTask;
            }


            DateTime birthday = Convert.ToDateTime(context.User.FindFirst(c => c.Type == ClaimTypes.DateOfBirth).Value);

         //  var X = DateTime.Now.Subtract(birthday);

            int age = DateTime.Now.Year - birthday.Year;

            //int newAge = DateTime.Compare(DateTime.Now, birthday);

            if(age >= minAge)
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;

        }
    }
}

