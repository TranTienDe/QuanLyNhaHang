using Microsoft.EntityFrameworkCore;
using QLBH_APIs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLBH_APIs.Data
{
    public class AppDbContext : DbContext
    {
        private readonly DbContextOptions<AppDbContext> options;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            this.options = options;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
