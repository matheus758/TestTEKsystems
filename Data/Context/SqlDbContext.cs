using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class SqlDbContext(DbContextOptions<SqlDbContext> options) : DbContext(options)
    {
        public DbSet<User> User { get; set; }
        //public DbSet<BidProduct> bidProducts { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Bid> bids { get; set; }

    }
}
