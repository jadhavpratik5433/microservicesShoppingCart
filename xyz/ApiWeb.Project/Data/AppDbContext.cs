using ApiWeb.Project.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiWeb.Project.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Coupon> Coupons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponID = 1,
                CouponCode = "SUMMER10",
                DiscountAmount = 10.0,
                MinAmount = 50
            });

            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponID = 2,
                CouponCode = "sanket",
                DiscountAmount = 20,
                MinAmount = 70
            });
        }
    }
}
