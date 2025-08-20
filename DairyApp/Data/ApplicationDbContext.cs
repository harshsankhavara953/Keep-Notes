using System.Data;
using DairyApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DairyApp.Data
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<DiaryEntry> DiaryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry
                {
                    Id = 1,
                    Title = "went hiking",
                    Content = "lets go to mountains",
                    Created= DateTime.Now
                },
                new DiaryEntry
                {
                    Id = 2,
                    Title = "went shopping",
                    Content = "went shopping with joe",
                    Created = DateTime.Now
                },
                new DiaryEntry
                {
                    Id = 3,
                    Title = "went playinh",
                    Content = "went playing with joe",
                    Created = DateTime.Now
                }
                );
        }
    }
}
    