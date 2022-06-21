using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Domain.Repositories;
using Services.Abstractions;
using Mapster;

namespace Services
{
    internal class UserService : IUserService
    {
        private readonly IRepositoryManager _repositoryManager;

        public UserService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task<UserDto> GetByIdAsync(int id)
        {
            var user =await _repositoryManager.UserRepository.GetByIdAsync(1);

            return user.Adapt<UserDto>();
        }
    }
}
