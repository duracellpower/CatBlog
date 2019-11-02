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
                        Age = 2,
                        Color = "black and white",
                        BestFail = "Taken by the police"
                    },

                    new Cat
                    {
                        Name = "Felix",
                        Age = 18,
                        Color = "Tiger",
                        BestFail = "Stealing candy"
                    },

                    new Cat
                    {
                        Name = "Nacho",
                        Age = 9,
                        Color = "black and white",
                        BestFail = "Bankrobery"
                    },

                    new Cat
                    {
                        Name = "Roxy",
                        Age = 4,
                        Color = "black",
                        BestFail = "Cursing everybody"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}