using Application.Interface.Repository;
using Core.Entities;
using Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class BidRepository : IBidRepository
    {
        readonly SqlDbContext sqlDbContext;

        public BidRepository(SqlDbContext sqlDbContext)
        {
            this.sqlDbContext = sqlDbContext;
        }

        public async Task<IEnumerable<Bid>> GetAll()
        {
            var result = await sqlDbContext.bids.ToListAsync();
            return result;
        }

        public async Task<Bid> New(Bid bid)
        {
            var result = sqlDbContext.bids.Add(bid);
            await sqlDbContext.SaveChangesAsync();
            return result.Entity;
        }
    }
}
