using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using MyTravels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTravels.Data
{
    public class ApplicationDbContextSeed
    {
        private UserManager<ApplicationUser> _userManager;

        public async Task SeedAsync(ApplicationDbContext context, IServiceProvider services)
        {
            using (var scope = services.CreateScope())
            {
                if (context.Users.Any())
                {
                    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

                    var defaultUser = new ApplicationUser
                    {
                        UserName = "Adminstrator",
                        Email = "xiao.peng1006@gmail.com",
                        NormalizedUserName = "admin"
                    };

                    var result = await _userManager.CreateAsync(defaultUser, "Password!23");

                    if (!result.Succeeded)
                    {
                        throw new Exception("Initialzing default user failed.");
                    }

                }
            }
        }
    }
}
