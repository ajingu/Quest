using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Model;

namespace Application.UseCase
{
    public interface IUserLoadUseCase
    {
        Task<IEnumerable<User>> LoadUsers();
    }
}