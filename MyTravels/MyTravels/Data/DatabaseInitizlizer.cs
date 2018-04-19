using MyTravels.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace MyTravels.Data
{
    internal class DatabaseInitizlizer : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            var post1 = new Post()
            {
                Id = 1,
                Title = "Hawaii trip",
                StartDate = DateTime.ParseExact("2017-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact("2017-01-06", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                Description = "Our first trip in Honoluu, Hawaii!"
            };
            context.Posts.Add(post2);

            var post2 = new Post()
            {
                Id = 2,
                Title = "Europe trip",
                StartDate = DateTime.ParseExact("2016-07-11", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact("2016-08-09", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                Description = "Travel to Italy, England and France!"
            };
            context.Posts.Add(post2);

            context.SaveChanges();
        }
    }
}
