using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.Repository
{
    public interface IBidProductRepository
    {
        public Task<BidProduct> New(BidProduct bidProduct);
        public Task<IEnumerable<BidProduct>> GetAll();
    }
}
