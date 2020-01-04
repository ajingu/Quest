using System.Collections.Generic;
using System.Threading.Tasks;
using Infrastructure.Entity;

namespace Infrastructure.Repository
{
    public interface IDatabase
    {
        Task<IEnumerable<UserEntity>> GetUsers();
    }
}
