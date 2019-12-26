using System.Collections.Generic;
using Application.UseCase;
using Domain.Model;
using Presentation.View;
using Zenject;

namespace Presentation.Presenter
{
    public class UserLoadPresenter : IUserLoadPresenter
    {
        [Inject]
        private UserTableView _userTableView;
        
        public void LoadUsers(IEnumerable<User> users)
        {
            _userTableView.LoadUsers(users);
        }
    }
}