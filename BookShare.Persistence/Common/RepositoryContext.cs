using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Persistence.Common
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextObtions obtions) : base(obtions) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            public DbSet<Book> books { get; set; }

    }
}
