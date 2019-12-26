using Domain.Translator;
using Application.UseCase;
using Zenject;

namespace Application.Interactor
{
    public class UserLoadInteractor : IUserLoadUseCase
    {
        [Inject] private IUserRepository _userRepository;
        [Inject] private IUserLoadPresenter _userLoadPresenter;

        public void LoadUsers()
        {
            var userEntities = _userRepository.FindAll();
            var users = UserTranslator.Translate(userEntities);

            _userLoadPresenter.LoadUsers(users);
        }
    }
}