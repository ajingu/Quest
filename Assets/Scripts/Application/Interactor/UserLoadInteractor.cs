using System.Collections.Generic;
using Domain.Translator;
using Application.UseCase;
using Domain.Model;
using Zenject;

namespace Application.Interactor
{
    public class UserLoadInteractor : IUserLoadUseCase
    {
        [Inject] private IUserRepository _userRepository;

        public IEnumerable<User> LoadUsers()
        {
            var userEntities = _userRepository.FindAll();
            var users = UserTranslator.Translate(userEntities);

            return users;
        }
    }
}