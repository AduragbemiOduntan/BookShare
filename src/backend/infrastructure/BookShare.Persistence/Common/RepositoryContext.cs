﻿using BookShare.Domain.Entities;
using BookShare.Persistence.Repositories;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookShare.Persistence.Common
{
    public class RepositoryContext : IdentityDbContext<User>
    {

        public RepositoryContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new RoleConfiguration());
        }

        DbSet<Book> books { get; set; }
        DbSet<BookCategory> bookCategories { get; set; }
        DbSet<Donation> donations { get; set; }
       
       /* DbSet<User> users { get; set; }*/
    }
}
