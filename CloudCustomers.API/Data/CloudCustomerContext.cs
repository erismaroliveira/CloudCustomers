using CloudCustomers.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CloudCustomers.API.Data;

public class CloudCustomerContext : DbContext
{
    public CloudCustomerContext(DbContextOptions<CloudCustomerContext> options) : base(options)
    { }

    public DbSet<User>? Users { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<User>()
            .HasData(new List<User>{
                new User(1, "Erismar", "Teste@123"),
                new User(2, "Natalia", "Teste@123"),
                new User(3, "Isabella", "Teste@123"),
                new User(4, "Eloah", "Teste@123")             
            });
    }
}