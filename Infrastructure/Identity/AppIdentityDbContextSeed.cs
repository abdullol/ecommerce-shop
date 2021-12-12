using Core.Entities;
using Core.Entities.OrderAggregate;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Identity
{
    class AppIdentityDbContextSeed
    {
        public static async Task SeedUserAync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "John",
                    Email = "test@test.com",
                    UserName = "test@test.com",
                    Address = new Address
                    {
                        FirstName = "John",
                        LastName = "John",
                        Street = "18 Street Lahore",
                        City = "Lahore",
                        State = "Lhr",
                        Zipcode = "12222"
                    }
                };
                await userManager.CreateAsync(user, "Pas$$w0rd");
            }
        }
    }
}
