using Microsoft.EntityFrameworkCore;
using NZwalks.Controllers;
using NZwalks.Mocks;
using NZwalks.Models;

namespace NZwalks.Data
{
    public class NZwalksDbContext(DbContextOptions dbContextOptions) : DbContext(dbContextOptions)
    {
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }

        public DbSet<Walks> Walks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var regions = MockData.RegionsMockData;
            var difficulties = MockData.DifficultyMockData;
            var walks = MockData.WalksMockData;

            modelBuilder.Entity<Region>().HasData(regions);
            modelBuilder.Entity<Difficulty>().HasData(difficulties);
            modelBuilder.Entity<Walks>().HasData(walks);
        }
    }
}
