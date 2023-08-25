using EProductCatalog.Models;
using Microsoft.EntityFrameworkCore;

namespace EProductCatalog.Context
{
    public class ApplicationContext: DbContext
    {
        public DbSet<Drinks> Drinks { get; set; }
        public DbSet<DrinkTypes> DrinkTypes { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Drinks>()
                 .Property(x => x.Id)
                 .HasColumnName("drinks_id");

            modelBuilder.Entity<DrinkTypes>()
                .Property(x => x.Id)
                .HasColumnName("drink_types_id");

            modelBuilder.Entity<DrinkTypes>()
                .HasMany(x => x.Drinks)
                .WithOne(y => y.DrinkType)
                .HasForeignKey(y => y.DrinkTypeId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
