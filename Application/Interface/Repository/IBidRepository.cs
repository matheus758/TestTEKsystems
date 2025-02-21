using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.Repository
{
    public interface IBidRepository
    {
        public Task<Bid> New(Bid bid);
        public Task<IEnumerable<Bid>> GetAll();
    }
}
