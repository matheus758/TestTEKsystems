using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.Repository
{
    public interface IProductRepository
    {
        public Task<Product> New(Product product);
        public Task<Product> Update(Product product);
        public Task<IEnumerable<Product>> GetAll();
        public Task<Product> GetById(int id);
    }
}
