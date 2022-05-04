using BookWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWeb.Data
{
    

    public class ApplicationDBContext : DbContext
    {
        public DbSet<User> User { get; set; }

        public DbSet<Book> Book { get; set; }

        public DbSet<Category> Category { get; set; }

        public DbSet<BookImg> BookImg { get; set; }

        public DbSet<Guest> Guest { get; set; }

        public DbSet<Order> Order { get; set; }

        public DbSet<OrderBook> OrderBook { get; set; }

        public DbSet<Role> Role { get; set; }

        public DbSet<Status> Status { get; set; }






        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }

  
}
