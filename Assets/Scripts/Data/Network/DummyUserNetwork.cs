using Data.DataStore;
using Data.Entity;

namespace Data.Network
{
    public class DummyUserNetwork : IUserNetwork
    {
        public UserEntity[] GetUsers()
        {
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

