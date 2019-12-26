using System.Collections.Generic;
using Infrastructure.Entity;

namespace Application.UseCase
{
    public interface IUserRepository
    {
        IEnumerable<UserEntity> FindAll();
    }
}
