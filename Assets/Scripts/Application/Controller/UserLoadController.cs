using Application.UseCase;
using Zenject;

namespace Application.Controller
{
    public class UserLoadController
    {
        [Inject] private IUserLoadUseCase _userLoadUseCase;

        public void LoadUser()
        {
            _userLoadUseCase.Load();
        }
    }
}