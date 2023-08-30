using LibraryAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookAuthors> BookAuthors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Borrow> Borrows { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<PaymentHistory> PaymentHistories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BookAuthors>()
                .HasKey(ba => new { ba.Book_BookID, ba.Author_AuthorID });

            modelBuilder.Entity<Review>()
                .HasKey(r => new { r.ReviewID});

            modelBuilder.Entity<Borrow>()
                .HasKey(b => new { b.Book_BookID, b.Membership_MembershipID });

            modelBuilder.Entity<PaymentHistory>()
                .HasKey(ph => new { ph.PaymentID});
        }

    }
}
