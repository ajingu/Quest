using Data.DataStore;
using Data.Entity;
using Domain.UseCase;
using Zenject;

namespace Domain.Repository
{
    public class UserRepository : IUserRepository
    {
        [Inject]
        private IUserDataStore _userDataStore;
   
        public UserEntity[] GetUsers()
        {
            var userEntities = _userDataStore.GetUsers();
            
            return userEntities;
        }
        
    }
}