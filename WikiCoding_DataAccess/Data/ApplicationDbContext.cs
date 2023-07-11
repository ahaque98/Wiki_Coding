using Microsoft.EntityFrameworkCore;
using WikiCoding_Model.Models;

namespace WikiCoding_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(data => data.Price).HasPrecision(10, 5);

            //seeding Data
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "The new tale",
                    ISBN = "1100001584279",
                    Price = 12.98m
                },

                new Book
                {
                    Id = 2,
                    Title = "once upon a time",
                    ISBN = "01561216803",
                    Price = 34.23m
                }
            );

            var bookList = new Book[]
            {
                new Book
                {
                    Id=3,
                    Title="Making a new faith",
                    ISBN="01725797413",
                    Price=32.45m
                },

                new Book
                {
                    Id=4,
                    Title="Big Star",
                    ISBN="10892163360",
                    Price=22.41m
                },
                new Book
                {
                    Id=5,
                    Title="B&H",
                    ISBN="9877654",
                    Price=11.21m
                }
            };

            modelBuilder.Entity<Book>().HasData(bookList); //passing bookList array to Db (Seeding)
        }
    }
}
