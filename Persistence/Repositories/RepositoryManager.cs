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
        private readonly RepositoryDbContext _context;

        private readonly Lazy<IUserRepository> _userRepository;

        
        public RepositoryManager(RepositoryDbContext dbContext)
        {
            _context = dbContext;
            
            _userRepository = new Lazy<IUserRepository>(() => new UserRepository(dbContext));
        }

        
        public IUserRepository UserRepository => _userRepository.Value;
        public IGenericRepository<T> GetGenericRepository<T>() where T : class
        {
            return new GenericRepository<T>(_context);
        }
    }
}
