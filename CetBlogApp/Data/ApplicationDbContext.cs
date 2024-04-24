using CetBlogApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CetBlogApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<CetUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Blog>   Blogs { get; set; }
    }
}
