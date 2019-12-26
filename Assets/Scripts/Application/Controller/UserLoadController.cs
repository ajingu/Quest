using Application.UseCase;
using Zenject;

namespace Application.Controller
{
    public class UserLoadController
    {
        [Inject] private IUserLoadUseCase _userLoadUseCase;

        public void LoadUsers()
        {
            _userLoadUseCase.LoadUsers();
        }
    }
}