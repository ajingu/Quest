using Domain.Model;

namespace Presentation.Presenter
{
    public interface IUsersTableView
    {
        void UpdateUsers(UserModel[] userModels);
    }
}