using Domain.Model;
using Domain.Translator;

namespace Domain.UseCase
{
    public class UserUseCase
    {
        private IUserRepository _userRepository;

        public UserUseCase(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserModel[] LoadUsers()
        {
            var userEntities = _userRepository.GetUsers();
            var userModels = UserTranslator.Translate(userEntities);
            
            return userModels;
        }
    }
}