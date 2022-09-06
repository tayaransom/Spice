using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Spice.Models;

namespace Spice.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Category { get; set; } = default!;
        public DbSet<SubCategory> SubCategory { get; set; } = default!;
        public DbSet<MenuItem> MenuItem { get; set; } = default!;
        public DbSet<Coupon> Coupon { get; set; } = default!;


    }
}