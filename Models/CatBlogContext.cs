using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CatBlog.Models
{
    public class CatBlogContext : IdentityDbContext
    {
        public CatBlogContext(DbContextOptions<CatBlogContext> options)
            : base(options)
        {
        }

        public DbSet<Cat> Cat { get; set; }
    }
}