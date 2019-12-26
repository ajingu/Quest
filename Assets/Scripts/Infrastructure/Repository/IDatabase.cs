using System.Collections.Generic;
using Infrastructure.Entity;

namespace Infrastructure.Repository
{
    public interface IDatabase
    {
        IEnumerable<UserEntity> GetUsers();
    }
}
