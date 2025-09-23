using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TooliRent.Domain.Entities;
using TooliRent.Infrastructure.Auth;

namespace TooliRent.Infrastructure.Persistence
{
    public class AppDbContext : IdentityDbContext<AppUser, IdentityRole<Guid>, Guid>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Tool> Tools => Set<Tool>();
        public DbSet<ToolCategory> ToolCategories => Set<ToolCategory>();
        public DbSet<Booking> Bookings => Set<Booking>();
        public DbSet<BookingItem> BookingItems => Set<BookingItem>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Tool → Category
            builder.Entity<Tool>()
                .HasOne(t => t.Category)
                .WithMany(c => c.Tools)
                .HasForeignKey(t => t.CategoryId);

            // BookingItem → Tool
            builder.Entity<BookingItem>()
                .HasOne(bi => bi.Tool)
                .WithMany()
                .HasForeignKey(bi => bi.ToolId);

            // BookingItem → Booking
            builder.Entity<BookingItem>()
                .HasOne(bi => bi.Booking)
                .WithMany(b => b.Items)
                .HasForeignKey(bi => bi.BookingId);
        }
    }
}
