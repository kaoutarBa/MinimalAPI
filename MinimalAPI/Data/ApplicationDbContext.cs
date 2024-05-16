namespace MinimalCouponAPI.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {

    }
    public DbSet<Coupon> Coupons { get; set; } // Coupons is a table name

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //these records will be added automatically when add migration
        modelBuilder.Entity<Coupon>().HasData(
            new Coupon()
            {
                Id = 1,
                Name = "10OFF",
                Percent = 10,
                IsActive = true
            },
            new Coupon()
            {
                Id = 2,
                Name = "20OFF",
                Percent = 20,
                IsActive = true
            },
            new Coupon()
            {
                Id = 3,
                Name = "30OFF",
                Percent = 30,
                IsActive = true
            });


    }
}

