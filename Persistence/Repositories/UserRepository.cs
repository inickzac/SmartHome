using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        
        private readonly RepositoryDbContext _dbContext;

        public UserRepository(RepositoryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User> GetByIdAsync(int accountId)
        {
            return await _dbContext.Users.FirstOrDefaultAsync((u) => u.Id == accountId);
        }
    }
}
