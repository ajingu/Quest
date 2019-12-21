using Data.Entity;
using Domain.Repository;

namespace Data.DataStore
{
    public class UserDataStore : IUserDataStore
    {
        public UserEntity[] GetUsers()
        {
            //Dummy
            var userEntities = new UserEntity[3]
            {
                new UserEntity(0, "Alice", false), 
                new UserEntity(1, "Bob", true), 
                new UserEntity(2, "Cindy", false), 
            };

            return userEntities;
        }
    }
}