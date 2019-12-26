using System.Collections.Generic;
using Domain.Model;
using Domain.Translator;
using Application.UseCase;
using Zenject;

namespace Application.Interactor
{
    public class UserLoadInteractor : IUserLoadUseCase
    {
        [Inject] private IUserRepository _userRepository;

        public IEnumerable<User> Load()
        {
            var userEntities = _userRepository.FindAll();
            var users = UserTranslator.Translate(userEntities);

            return users;
        }
    }
}