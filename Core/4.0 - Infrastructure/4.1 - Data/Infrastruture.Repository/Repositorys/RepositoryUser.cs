using Domain.Core.Interfaces.Repositorys;
using Domain.Models;
using Infrastructure.Data;
namespace Infrastruture.Repository.Repositorys
{
    public class RepositoryUser : RepositoryBase<User>, IRepositoryUser
    {
        private readonly SqlContext _context;
        public RepositoryUser(SqlContext Context)
            : base(Context)
        {
            _context = Context;
        }
    }
}
