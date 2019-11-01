using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace CatBlog.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CatBlogContext(
                serviceProvider.GetRequiredService<DbContextOptions<CatBlogContext>>()))
            {
                // Look for any cats.
                if (context.Cat.Any())
                {
                    return;   // DB has been seeded
                }

                context.Cat.AddRange(
                    new Cat
                    {
                        Name = "Mio Bonsai",
                        BirthDate = DateTime.Parse("2017-12-06"),
                        Color = "black and white",
                    },

                    new Cat
                    {
                        Name = "Felix",
                        BirthDate = DateTime.Parse("2000-8-1"),
                        Color = "Tiger",
                    },

                    new Cat
                    {
                        Name = "Nacho",
                        BirthDate = DateTime.Parse("2010-2-23"),
                        Color = "black and white",
                    },

                    new Cat
                    {
                        Name = "Roxy",
                        BirthDate = DateTime.Parse("2014-4-15"),
                        Color = "black",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}