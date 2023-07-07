using BookShare.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Persistence.Common
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options) { }
        
        DbSet<Book> books { get; set; }
        DbSet<BookCategory> bookCategories { get; set; }
        DbSet<Donation> donations { get; set; }
        DbSet<User> users { get; set; }
    }
}
