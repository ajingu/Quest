using Domain.Repository;
using Domain.Model;
using Domain.Translator;

namespace Domain.UseCase
{
    public class UserUseCase
    {
        private UserRepository _userRepository;

        public UserUseCase(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UsersModel LoadUsers()
        {
            var userEntities = _userRepository.GetUsers();
            var usersModel = UserTranslator.Translate(userEntities);
            
            return usersModel;
        }
    }
}