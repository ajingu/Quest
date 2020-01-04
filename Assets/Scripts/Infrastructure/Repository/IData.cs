using System.Collections.Generic;
using System.Threading.Tasks;
using Infrastructure.Entity;

namespace Infrastructure.Repository
{
    public interface IData
    {
        Task<IEnumerable<UserEntity>> GetUsers();
    }
}
