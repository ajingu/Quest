using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Translator;
using Application.UseCase;
using Domain.Model;
using Zenject;

namespace Application.Interactor
{
    public class UserLoadInteractor : IUserLoadUseCase
    {
        [Inject] private IUserRepository _userRepository;

        public async Task<IEnumerable<User>> LoadUsers()
        {
            var userEntities = await _userRepository.FindAll();
            var users = UserTranslator.Translate(userEntities);

            return users;
        }
    }
}