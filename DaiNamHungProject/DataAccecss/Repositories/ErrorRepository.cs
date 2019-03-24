using DataAccecss.InterfaceRepositories;
using DataAccecss.Model;

namespace DataAccecss.Repositories
{
    public interface IErrorRepository : IRepository<Error>
    {
    }

    class ErrorRepository : RepositoryBase<Error>, IErrorRepository
    {
        public ErrorRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}