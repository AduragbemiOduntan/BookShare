using BookShare.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Persistence.Common
{
    public class RepositoryContext : IdentityDbContext<User>
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

            public RepositoryContext(DbContextOptions options) : base(options) { }
        
        DbSet<Book> books { get; set; }
        DbSet<BookCategory> bookCategories { get; set; }
        DbSet<Donation> donations { get; set; }
        DbSet<User> users { get; set; }
    }
}
