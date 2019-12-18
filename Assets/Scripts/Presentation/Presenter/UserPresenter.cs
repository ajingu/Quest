using Domain.UseCase;
using Presentation.View;

namespace Presentation.Presenter
{
    public class UserPresenter
    {
        private UserUseCase _userUseCase;
        private UsersTable _usersTable;

        public UserPresenter(UserUseCase userUseCase, UsersTable usersTable)
        {
            _userUseCase = userUseCase;
            _usersTable = usersTable;
        }
    }
}