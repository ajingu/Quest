using Data.DataStore;
using Data.Entity;
using Domain.UseCase;

namespace Domain.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDataStore _userDataStore;

        public UserRepository(UserDataStore userDataStore)
        {
            _userDataStore = userDataStore;
        }

        public UserEntity[] GetUsers()
        {
            var userEntities = _userDataStore.GetUsers();
            
            return userEntities;
        }
        
    }
}