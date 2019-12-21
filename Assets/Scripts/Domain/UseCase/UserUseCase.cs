using Domain.Model;
using Domain.Translator;
using Zenject;

namespace Domain.UseCase
{
    public class UserUseCase
    {
        [Inject]
        private IUserRepository _userRepository;

        public UserModel[] LoadUsers()
        {
            var userEntities = _userRepository.GetUsers();
            var userModels = UserTranslator.Translate(userEntities);
            
            return userModels;
        }
    }
}