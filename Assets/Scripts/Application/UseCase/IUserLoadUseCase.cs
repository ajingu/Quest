using System.Collections.Generic;
using Domain.Model;

namespace Application.UseCase
{
    public interface IUserLoadUseCase
    {
        IEnumerable<User> LoadUsers();
    }
}