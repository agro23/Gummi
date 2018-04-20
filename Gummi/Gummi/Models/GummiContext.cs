using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Gummi.Models
{
    public class GummiDbContext : DbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<GummiUser> GummiUsers { get; set; }

        public GummiDbContext()
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //    => optionsBuilder
        //        .UseMySql(@"Server=localhost;Port=8889;database=gummi;uid=root;pwd=root;");

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    options.UseMySql(@"Server=localhost;Port=8889;database=gummi;uid=root;pwd=root;");
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(Startup.ConnectionString);
        }


        public GummiDbContext(DbContextOptions<GummiDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}