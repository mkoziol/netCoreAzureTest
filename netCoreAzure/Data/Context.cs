

using Microsoft.EntityFrameworkCore;

namespace netCoreAzure.Data
{
    public class Context : DbContext
    {
        public DbSet<tableName> Users { get; set; }

        public Context() : base()
        {
        }

        public static string ConnectionString { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tableName>(entity =>
            {
                entity.Property(e => e.Id);

                entity.Property(e => e.Name).HasMaxLength(50);
            });
        }
    }
}
