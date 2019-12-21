using Data.Entity;
using Domain.Repository;
using Zenject;

namespace Data.DataStore
{
    public class UserDataStore : IUserDataStore
    {
        [Inject]
        private IUserNetwork _userNetwork;
        
        public UserEntity[] GetUsers()
        {
            var userEntities = _userNetwork.GetUsers();
            return userEntities;
        }
    }
}