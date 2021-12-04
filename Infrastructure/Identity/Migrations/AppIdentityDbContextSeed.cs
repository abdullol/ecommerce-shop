using Core.Entities;
using Core.Entities.OrderAggregate;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Infrastructure.Identity.Migrations
{
    class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "John",
                    Email = "john@test.com",
                    UserName = "john@test.com",
                    Address = new Address
                    {
                        FirstName = "John",
                        LastName = "Johns",
                        Street = "Ten down street",
                        City = "New york",
                        State = "NY",
                        Zipcode = "90BBG1"
                    }
                };
                await userManager.CreateAsync(user,"Pa$$w0rd");
            }
        }
    }
}
