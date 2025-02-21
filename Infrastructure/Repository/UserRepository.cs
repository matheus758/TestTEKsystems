using Application.Interface.Repository;
using Core.Entities;
using Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        readonly SqlDbContext sqlDbContext;

        public UserRepository(SqlDbContext sqlDbContext)
        {
            this.sqlDbContext = sqlDbContext;
        }

        public async Task Delete(User user)
        {
            sqlDbContext.User.Remove(user);
            await sqlDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            var result = await sqlDbContext.User.ToListAsync();
            return result;
        }

        public async Task<User> New(User user)
        {
           var result = sqlDbContext.User.Add(user);
            await sqlDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<User> Update(User user)
        {
            var result  = sqlDbContext.Update(user);
            await sqlDbContext.SaveChangesAsync();
            return result.Entity;
        }
    }
}
