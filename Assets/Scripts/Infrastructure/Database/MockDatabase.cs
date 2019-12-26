using System.Collections.Generic;
using Infrastructure.Entity;
using Infrastructure.Repository;

namespace Infrastructure.Database
{
    public class DummyDatabase : IDatabase
    {
        public IEnumerable<UserEntity> GetUsers()
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

