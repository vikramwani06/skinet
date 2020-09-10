using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                // var user = new AppUser
                // {
                //     DisplayName = "Viki",
                //     Email = "viki@test.com",
                //     UserName = "viki@test.com",
                //     Address = new Address
                //     {
                //         FirstName = "Viki",
                //         LastName = "Vikiti",
                //         Street = "10th Street",
                //         City = "Harrison",
                //         State = "New York",
                //         ZipCode = "07030"
                //     }
                // };

                var user = new AppUser
                {
                    DisplayName = "Bob",
                    Email = "bob@test.com",
                    UserName = "bob@test.com",
                    Address = new Address
                    {
                        FirstName = "Bob",
                        LastName = "Bobbity",
                        Street = "10 The Street",
                        City = "New York",
                        State = "NY",
                        ZipCode = "90210"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}