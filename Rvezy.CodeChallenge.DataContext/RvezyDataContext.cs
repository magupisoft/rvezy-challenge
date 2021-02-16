using Microsoft.EntityFrameworkCore;
using Rvezy.CodeChallenge.Models;

namespace Rvezy.CodeChallenge.DataContext
{
    public class RvezyDataContext : DbContext
    {
        public RvezyDataContext(DbContextOptions<RvezyDataContext> options) : base(options)
        {
        }

        public DbSet<ListingModel> Listing { get; set; }
        public DbSet<CalendarModel> Calendar { get; set; }
        public DbSet<ReviewModel> Review { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<CalendarModel>()
                    .Property(p => p.Id)
                    .ValueGeneratedOnAdd().UseIdentityColumn();
            modelBuilder
                .Entity<CalendarModel>().ToTable("Calendar");
            modelBuilder
                .Entity<CalendarModel>()
                    .HasOne(s => s.Listing)
                    .WithMany(g => g.Calendars)
                    .HasForeignKey(s => s.ListingId);

            modelBuilder
                .Entity<ListingModel>()
                    .Property(p => p.Id)
                    .ValueGeneratedNever();
            modelBuilder.Entity<ListingModel>().ToTable("Listing");
            

            modelBuilder
                .Entity<ReviewModel>()
                    .Property(p => p.Id)
                    .ValueGeneratedNever();
            modelBuilder.Entity<ReviewModel>().ToTable("Review");
            modelBuilder
                .Entity<ReviewModel>()
                    .HasOne(s => s.Listing)
                    .WithMany(g => g.Reviews)
                    .HasForeignKey(s => s.ListingId);
        }

        
    }
}
