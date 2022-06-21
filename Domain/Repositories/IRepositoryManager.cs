namespace Domain.Repositories
{
    public interface IRepositoryManager
    {
        IUserRepository UserRepository { get; }

        public IGenericRepository<T> GetGenericRepository<T>() where T : class;

    }
}
