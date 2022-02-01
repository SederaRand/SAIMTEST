using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {}

        public DbSet<User> User { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Contact> Contact { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>(b =>
            {          

                b.HasKey(x => x.IdCompany);

                b.Property(x => x.IdCompany).ValueGeneratedOnAdd();

                b.Property(x => x.Details).IsRequired(true);

                b.HasIndex(x => x.Address);
            });

            modelBuilder.Entity<User>(b =>
            {

                b.HasKey(x => x.IdUser);

                b.Property(x => x.IdUser).ValueGeneratedOnAdd();

                b.Property(x => x.Username).IsRequired(true);

                b.Property(x => x.Email).IsRequired(true);

                b.Property(x => x.Password).IsRequired(true);
            });

            modelBuilder.Entity<Contact>(b =>
            {

                b.HasKey(x => x.IdContact);

                b.Property(x => x.IdContact).ValueGeneratedOnAdd();

                b.Property(x => x.FirstName).IsRequired(true);

                b.Property(x => x.LastName).IsRequired(true);

               // b.Property(x => x.CompanyName).IsRequired(true);
            });

            modelBuilder.Entity<Contact>()
                .HasOne(p => p.CompanyName);
        }
    }
}
