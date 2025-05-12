using AgroSys.Domain;
using Microsoft.EntityFrameworkCore;

namespace AgroSys.Repository
{
    public class AgroSysDbContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }

        public DbSet<Cattleman> CattleMans { get; set; }

        public AgroSysDbContext(DbContextOptions<AgroSysDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cattleman>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Animal>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Name).IsRequired();

                // Relación con Cattleman
                entity.HasOne<Cattleman>()
                      .WithMany()
                      .HasForeignKey(a => a.CattleManID)
                      .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}
