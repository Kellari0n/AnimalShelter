using AnimalShelter.Entities;

using Microsoft.EntityFrameworkCore;

using System.Configuration;

namespace AnimalShelter.Context {
    public class AppDbContext : DbContext {
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Cage> Cages { get; set; }
        public DbSet<Adoption> Adoptions { get; set; }
        public DbSet<Shelter> Shelters { get; set; }
        public DbSet<IncomeReport> IncomeReports { get; set; }

        public AppDbContext() : base() {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            
        }
    }
}