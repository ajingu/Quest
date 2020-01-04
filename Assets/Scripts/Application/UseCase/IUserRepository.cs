using System.Collections.Generic;
using System.Threading.Tasks;
using Infrastructure.Entity;

namespace Application.UseCase
{
    public interface IUserRepository
    {
        Task<IEnumerable<UserEntity>> FindAll();
    }
}
