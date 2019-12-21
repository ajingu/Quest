using Domain.UseCase;

namespace Presentation.Presenter
{
    public class UserPresenter : IUserPresenter
    {
        private UserUseCase _userUseCase;
        private IUsersTableView _usersTableView;

        public UserPresenter(UserUseCase userUseCase, IUsersTableView usersTableView)
        {
            _userUseCase = userUseCase;
            _usersTableView = usersTableView;
        }
        
        public void LoadUsers()
        {
            var userModels = _userUseCase.LoadUsers();
            _usersTableView.UpdateUsers(userModels);
        }
    }
}