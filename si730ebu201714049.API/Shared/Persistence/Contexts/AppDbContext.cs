using Microsoft.EntityFrameworkCore;
using si730ebu201714049.API.Loyalty.Domain.Models;
using si730ebu201714049.API.Shared.Extensions;

namespace si730ebu201714049.API.Shared.Persistence.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options){}

    public DbSet<Reward> Rewards { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        builder.Entity<Reward>().ToTable("Rewards");

        builder.Entity<Reward>().HasKey(p => p.Id);
        builder.Entity<Reward>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Reward>().Property(p => p.FleetId).IsRequired();
        builder.Entity<Reward>().Property(p => p.Name).IsRequired();
        builder.Entity<Reward>().Property(p => p.Description).IsRequired(false);
        builder.Entity<Reward>().Property(p => p.Score).IsRequired();

        builder.UseSnakeCaseNamingConvention();
    }
}