
using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class RepositoryIdentityDbContext : IdentityDbContext<User>
    {

        public RepositoryIdentityDbContext(DbContextOptions<RepositoryIdentityDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
