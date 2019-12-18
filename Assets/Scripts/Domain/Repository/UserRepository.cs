using Data.DataStore;
using Data.Entity;

namespace Domain.Repository
{
    public class UserRepository
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