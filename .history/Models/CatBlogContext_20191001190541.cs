using Microsoft.EntityFrameworkCore;

namespace CatBlog.Models
{
    public class CatBlogContext : DbContext
    {
        public CatBlogContext (DbContextOptions<CatBlogContext> options)
            : base(options)
        {
        }

        public DbSet<Cat> Cat { get; set; }
    }
}