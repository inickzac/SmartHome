using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Repositories;

namespace Persistence.Repositories
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly Lazy<IUserRepository> _userRepository;

        public RepositoryManager(RepositoryDbContext dbContext)
        {
            _userRepository = new Lazy<IUserRepository>(() => new UserRepository(dbContext));
        }

        

        public IUserRepository UserRepository { get; }
        public IGenericRepository<T> GetGenericRepository<T>() where T : class
        {
            throw new NotImplementedException();
        }
    }
}
