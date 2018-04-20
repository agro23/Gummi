using System;
using Microsoft.EntityFrameworkCore;
using Gummi.Models;

namespace Gummi.Models
{
    public class GummiContext : DbContext
    {

        public GummiDbContext ()
        {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<GummiUsers> GummiUsers { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //    => optionsBuilder
        //        .UseMySql(@"Server=localhost;Port=8889;database=gummi;uid=root;pwd=root;");

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(@"Server=localhost;Port=8889;database=gummi;uid=root;pwd=root;");
        }

        public ToDoDbContext(DbContextOptions<ToDoDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}