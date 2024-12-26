using Microsoft.EntityFrameworkCore;

public class EmlakDbContext : DbContext
{
    public DbSet<Estate> Estates { get; set; }

    public EmlakDbContext(DbContextOptions<EmlakDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.HasDefaultSchema("public");

        // Entity yapılandırmalarını burada yapın
        modelBuilder.Entity<Estate>(entity =>
        {
            entity.ToTable("Estates", "public");
            entity.HasKey(e => e.Id);
        });
    }
}