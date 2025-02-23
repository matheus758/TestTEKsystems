using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.Repository
{
    public interface IUserRepository
    {
        public Task<User> NewAsync(User user);
        public User New(User user);
        public Task<User> Update(User user);
        public Task Delete(User user);
        public Task<IEnumerable<User>> GetAllAsync();
        public IEnumerable<User> GetAll();

    }
}
