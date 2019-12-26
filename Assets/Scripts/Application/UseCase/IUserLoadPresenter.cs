using System.Collections.Generic;
using Domain.Model;

namespace Application.UseCase
{
    public interface IUserLoadPresenter
    {
        void LoadUsers(IEnumerable<User> users);
    }
}