using Application.Interface.Repository;
using Core.Entities;
using Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class ProductRepository : IProductRepository
    {
        readonly SqlDbContext sqlDbContext;

        public ProductRepository(SqlDbContext sqlDbContext)
        {
            this.sqlDbContext = sqlDbContext;
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            var result = await sqlDbContext.products.ToListAsync();
            return result;
        }

        public async Task<Product> GetById(int id)
        {
            var result = await sqlDbContext.products.Where(x => x.Id == id).FirstOrDefaultAsync();
            return result;
        }

        public async Task<Product> New(Product product)
        {
            var result = sqlDbContext.products.Add(product);
            await sqlDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Product> Update(Product product)
        {
            var result = sqlDbContext.Update(product);
            await sqlDbContext.SaveChangesAsync();
            return result.Entity;
        }
    }
}
