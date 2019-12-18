using Data.Entity;

namespace Data.DataStore
{
    public class UserDataStore
    {
        public UserEntity[] GetUsers()
        {
            //Dummy
            var userEntities = new UserEntity[3]
            {
                new UserEntity(0, "Alice", 0), 
                new UserEntity(1, "Bob", 1000), 
                new UserEntity(2, "Cindy", 2000), 
            };

            return userEntities;
        }
    }
}